using System.IO.Compression;
using ScriptEngine.Machine;
using ScriptEngine.Machine.Contexts;

#if NET48
using ScriptEngine.HostedScript.Library.Binary;
#else
using OneScript.Contexts;
#endif

namespace OscriptCompressor
{
    /// <summary>
    /// Класс для упаковки/распаковки данных в Brotli.
    /// </summary>
    [ContextClass("BrotliКомпрессор", "BrotliCompressor")]
    public class BrotliCompressor : BaseCompressor
    {
        /// <summary>
        /// Создает новый экземпляр класса BrotliCompressor.
        /// </summary>
        public BrotliCompressor() : this(DataCompressionLevel.Fastest)
        {
        }

        /// <summary>
        /// Создает новый экземпляр класса BrotliCompressor.
        /// </summary>
        public BrotliCompressor(DataCompressionLevel level)
        {
            var compressionLevel = (CompressionLevel)(int)level;
#if NET48
            _compressor = new EasyCompressor.BrotliNETCompressor(compressionLevel);
#else
            _compressor = new EasyCompressor.BrotliCompressor(compressionLevel);
#endif
        }

        /// <summary>
        /// Создает новый экземпляр класса BrotliCompressor.
        /// </summary>
        /// <returns>BrotliCompressor</returns>
        [ScriptConstructor]
        public static BrotliCompressor Constructor()
        {
            return new BrotliCompressor();
        }

        /// <summary>
        /// Создает новый экземпляр класса BrotliCompressor.
        /// </summary>
        /// <returns>BrotliCompressor</returns>
        [ScriptConstructor]
        public static BrotliCompressor Constructor(IValue level)
        {
            return new BrotliCompressor(ContextValuesMarshaller.ConvertParam<DataCompressionLevel>(level));
        }
    }
}
