#if NET6_0

using System.IO.Compression;
using ScriptEngine.Machine;
using ScriptEngine.Machine.Contexts;

using OneScript.Contexts;

namespace OscriptCompressor
{
    /// <summary>
    /// Класс для упаковки/распаковки данных в ZLib.
    /// </summary>
    [ContextClass("ZLibКомпрессор", "ZLibCompressor")]
    public class ZLibCompressor : BaseCompressor
    {
        /// <summary>
        /// Создает новый экземпляр класса ZLibCompressor.
        /// </summary>
        public ZLibCompressor() : this(DataCompressionLevel.Fastest)
        {
        }

        /// <summary>
        /// Создает новый экземпляр класса ZLibCompressor.
        /// </summary>
        public ZLibCompressor(DataCompressionLevel level)
        {
            _compressor = new EasyCompressor.ZLibCompressor((CompressionLevel)(int)level);
        }

        /// <summary>
        /// Создает новый экземпляр класса ZLibCompressor.
        /// </summary>
        /// <returns>ZLibCompressor</returns>
        [ScriptConstructor]
        public static ZLibCompressor Constructor()
        {
            return new ZLibCompressor();
        }

        /// <summary>
        /// Создает новый экземпляр класса ZLibCompressor.
        /// </summary>
        /// <returns>ZLibCompressor</returns>
        [ScriptConstructor]
        public static ZLibCompressor Constructor(IValue level)
        {
            return new ZLibCompressor(ContextValuesMarshaller.ConvertParam<DataCompressionLevel>(level));
        }
    }
}
#endif