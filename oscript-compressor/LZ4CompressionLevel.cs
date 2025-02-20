using K4os.Compression.LZ4;

#if NET48
using ScriptEngine;
#else
using OneScript.Contexts.Enums;
#endif

namespace OscriptCompressor
{
    /// <summary>
    /// ZStandard Compression Level
    /// </summary>
    [EnumerationType("УровеньСжатияДанныхLZ4", "LZ4CompressionLevel")]
    public enum LZ4CompressionLevel
    {

        /// <summary>Fast compression.</summary>
#if NET48
        [EnumItem("L00_FAST")]
#else
        [EnumValue("L00_FAST")]
#endif
        L00_FAST = LZ4Level.L00_FAST,

        /// <summary>High compression, level 3.</summary>
#if NET48
        [EnumItem("L03_HC")]
#else
        [EnumValue("L03_HC")]
#endif
        L03_HC = LZ4Level.L03_HC,

        /// <summary>High compression, level 4.</summary>
#if NET48
        [EnumItem("L04_HC")]
#else
        [EnumValue("L04_HC")]
#endif
        L04_HC = LZ4Level.L04_HC,

        /// <summary>High compression, level 5.</summary>
#if NET48
        [EnumItem("L05_HC")]
#else
        [EnumValue("L05_HC")]
#endif
        L05_HC = LZ4Level.L05_HC,

        /// <summary>High compression, level 6.</summary>
#if NET48
        [EnumItem("L06_HC")]
#else
        [EnumValue("L06_HC")]
#endif
        L06_HC = LZ4Level.L06_HC,

        /// <summary>High compression, level 7.</summary>
#if NET48
        [EnumItem("L07_HC")]
#else
        [EnumValue("L07_HC")]
#endif
        L07_HC = LZ4Level.L07_HC,

        /// <summary>High compression, level 8.</summary>
#if NET48
        [EnumItem("L08_HC")]
#else
        [EnumValue("L08_HC")]
#endif
        L08_HC = LZ4Level.L08_HC,

        /// <summary>High compression, level 9.</summary>
#if NET48
        [EnumItem("L09_HC")]
#else
        [EnumValue("L09_HC")]
#endif
        L09_HC = LZ4Level.L09_HC,

        /// <summary>Optimal compression, level 10.</summary>
#if NET48
        [EnumItem("L10_OPT")]
#else
        [EnumValue("L10_OPT")]
#endif
        L10_OPT = LZ4Level.L10_OPT,

        /// <summary>Optimal compression, level 11.</summary>
#if NET48
        [EnumItem("L11_OPT")]
#else
        [EnumValue("L11_OPT")]
#endif
        L11_OPT = LZ4Level.L11_OPT,

        /// <summary>Maximum compression, level 12.</summary>
#if NET48
        [EnumItem("L12_MAX")]
#else
        [EnumValue("L12_MAX")]
#endif
        L12_MAX = LZ4Level.L12_MAX,
    }
}