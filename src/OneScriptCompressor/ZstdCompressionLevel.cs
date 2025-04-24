#if NET48
using ScriptEngine;
#else
using OneScript.Contexts.Enums;
#endif

namespace OneScriptCompressor
{
    /// <summary>
    /// ZStandard Compression Level
    /// </summary>
    [EnumerationType("УровеньСжатияДанныхZstd", "ZstdCompressionLevel")]
    public enum ZstdCompressionLevel
    {
        /// <summary>
        /// No compression should be performed on the file. (Equals to <c>-131072</c>)
        /// </summary>
#if NET48
        [EnumItem("БезСжатия", "NoCompression")]
#else
        [EnumValue("БезСжатия", "NoCompression")]
#endif
        NoCompression = EasyCompressor.ZstdCompressionLevel.NoCompression,

        /// <summary>
        /// The compression operation should complete as quickly as possible, even if the resulting file is not optimally compressed. (Equals to <c>-22</c>)
        /// </summary>
#if NET48
        [EnumItem("Быстрый", "Fastest")]
#else
        [EnumValue("Быстрый", "Fastest")]
#endif
        Fastest = EasyCompressor.ZstdCompressionLevel.Fastest,

        /// <summary>
        /// The compression operation should optimally balance compression speed and output size. (Our Default - Equals to <c>-1</c>)
        /// </summary>
#if NET48
        [EnumItem("ПоУмолчанию", "Default")]
#else
        [EnumValue("ПоУмолчанию", "Default")]
#endif
        Default = EasyCompressor.ZstdCompressionLevel.Fast,

        /// <summary>
        /// The compression operation should optimally balance compression speed and output size. (ZStandard Default - Equals to <c>3</c> or <c>0</c>)
        /// </summary>
#if NET48
        [EnumItem("Оптимальный", "Optimal")]
#else
        [EnumValue("Оптимальный", "Optimal")]
#endif
        Optimal = EasyCompressor.ZstdCompressionLevel.Optimal,

        /// <summary>
        /// The compression operation should create output as small as possible, even if the operation takes a longer time to complete. (Equals to <c>22</c>)
        /// </summary>
#if NET48
        [EnumItem("НаименьшийРазмер", "SmallestSize")]
#else
        [EnumValue("НаименьшийРазмер", "SmallestSize")]
#endif
        SmallestSize = EasyCompressor.ZstdCompressionLevel.SmallestSize,
    }
}