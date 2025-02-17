using System.IO;
using EasyCompressor;
using ScriptEngine.Machine;
using ScriptEngine.Machine.Contexts;

#if NET48
using ScriptEngine.HostedScript.Library.Binary;
#else
using OneScript.Contexts;
using OneScript.StandardLibrary.Binary;
using OneScript.Exceptions;
#endif

namespace OscriptCompressor
{
    public abstract class BaseCompressor : AutoContext<BaseCompressor>, ICompressor
    {
        protected EasyCompressor.ICompressor _compressor;

        /// <summary>
        /// Упаковывает данные.
        /// </summary>
        /// <param name="data">Исходные данные</param>
        /// <param name="outputStream">Поток для записи упакованных данных</param>
        /// <returns>Упакованные двоичные данные, когда не указан поток для записи</returns>
        [ContextMethod("Упаковать", "Compress")]
        public IValue Compress(IValue data, IValue outputStream = null)
        {
            var dataObj = data.AsObject();

            if (dataObj is BinaryDataContext binaryData)
            {
                return ProcessBytes(binaryData.Buffer, outputStream, true);
            }
            else if (dataObj is IStreamWrapper inputStreamWraper)
            {
                return ProcessStream(inputStreamWraper.GetUnderlyingStream(), outputStream, true);
            }
            else
            {
                throw RuntimeException.InvalidArgumentType("data");
            }
        }

        /// <summary>
        /// Распаковывает данные.
        /// </summary>
        /// <param name="data">Упакованные данные</param>
        /// <param name="outputStream">Поток для записи распакованных данных</param>
        /// <returns>Распакованные двоичные данные, когда не указан поток для записи</returns>
        [ContextMethod("Распаковать", "Decompress")]
        public IValue Decompress(IValue data, IValue outputStream = null)
        {
            var dataObj = data.AsObject();

            if (dataObj is BinaryDataContext binaryData)
            {
                return ProcessBytes(binaryData.Buffer, outputStream, false);
            }
            else if (dataObj is IStreamWrapper inputStreamWraper)
            {
                return ProcessStream(inputStreamWraper.GetUnderlyingStream(), outputStream, false);
            }
            else
            {
                throw RuntimeException.InvalidArgumentType("data");
            }
        }

        private IValue ProcessBytes(byte[] bytes, IValue output, bool isCompress)
        {
            if (output is null)
            {
                byte[] compressedData;

                if (isCompress)
                    compressedData = _compressor.Compress(bytes);
                else
                    compressedData = _compressor.Decompress(bytes);

                return new BinaryDataContext(compressedData);
            }
            else if (output.AsObject() is IStreamWrapper outputStreamWraper)
            {
                using var inputStream = new MemoryStream(bytes);
                var outputStream = outputStreamWraper.GetUnderlyingStream();

                if (isCompress)
                    _compressor.Compress(inputStream, outputStream);
                else
                    _compressor.Decompress(inputStream, outputStream);

                return null;
            }
            else
            {
                throw RuntimeException.InvalidArgumentType("output");
            }
        }

        private IValue ProcessStream(Stream inputStream, IValue output, bool isCompress)
        {
            Stream outputStream;

            if (output is null)
            {
                outputStream = new MemoryStream();
            }
            else if (output.AsObject() is IStreamWrapper outputStreamWraper)
            {
                outputStream = outputStreamWraper.GetUnderlyingStream();
            }
            else
            {
                throw RuntimeException.InvalidArgumentType("output");
            }

            if (isCompress)
                _compressor.Compress(inputStream, outputStream);
            else
                _compressor.Decompress(inputStream, outputStream);

            if (output is null)
            {
                outputStream.Seek(0, SeekOrigin.Begin);
                var bytes = outputStream.ReadAllBytes();
                outputStream.Dispose();
                return new BinaryDataContext(bytes);
            }
            else
            {
                return null;
            }
        }
    }
}
