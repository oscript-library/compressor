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
    /// Класс для упаковки/распаковки данных в GZip.
    /// </summary>
    [ContextClass("GZipКомпрессор", "GZipCompressor")]
    public class GZipCompressor : BaseCompressor
    {
        /// <summary>
        /// Создает новый экземпляр класса GZipCompressor.
        /// </summary>
        public GZipCompressor() : this(DataCompressionLevel.Fastest)
        {
        }

        /// <summary>
        /// Создает новый экземпляр класса GZipCompressor.
        /// </summary>
        public GZipCompressor(DataCompressionLevel level)
        {
            _compressor = new EasyCompressor.GZipCompressor((CompressionLevel)(int)level);
        }

        /// <summary>
        /// Создает новый экземпляр класса GZipCompressor.
        /// </summary>
        /// <returns>GZipCompressor</returns>
        [ScriptConstructor]
        public static GZipCompressor Constructor()
        {
            return new GZipCompressor();
        }

        /// <summary>
        /// Создает новый экземпляр класса GZipCompressor.
        /// </summary>
        /// <returns>GZipCompressor</returns>
        [ScriptConstructor]
        public static GZipCompressor Constructor(IValue level)
        {
            return new GZipCompressor(ContextValuesMarshaller.ConvertParam<DataCompressionLevel>(level));
        }
    }
}
