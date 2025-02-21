using ScriptEngine.Machine;
using ScriptEngine.Machine.Contexts;

#if NET6_0
using OneScript.Contexts;
#endif

namespace OscriptCompressor
{
    /// <summary>
    /// Класс для упаковки/распаковки данных в Snappy.
    /// </summary>
    [ContextClass("SnappyКомпрессор", "SnappyCompressor")]
    public class SnappyCompressor : BaseCompressor
    {
        /// <summary>
        /// Создает новый экземпляр класса SnappyCompressor.
        /// </summary>
        public SnappyCompressor()
        {
            _compressor = new EasyCompressor.SnappierCompressor();
        }

        /// <summary>
        /// Создает новый экземпляр класса SnappyCompressor.
        /// </summary>
        /// <returns>SnappyCompressor</returns>
        [ScriptConstructor]
        public static SnappyCompressor Constructor()
        {
            return new SnappyCompressor();
        }
    }
}
