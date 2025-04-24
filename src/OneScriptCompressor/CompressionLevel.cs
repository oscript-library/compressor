#if NET48
using ScriptEngine;
#else
using OneScript.Contexts.Enums;
#endif

namespace OneScriptCompressor
{
    /// <summary>
    /// Задает значения, показывающие, выделяет ли операция сжатия скорость или размер
    /// сжатого файла.
    /// </summary>
    [EnumerationType("УровеньСжатияДанных", "DataCompressionLevel")]
    public enum DataCompressionLevel
    {
        /// <summary>
        /// При операции сжатия должно применяться оптимальное сжатие, даже если это увеличивает
        /// длительность ее выполнения.
        /// </summary>
#if NET48
        [EnumItem("Оптимальный", "Optimal")]
#else
        [EnumValue("Оптимальный", "Optimal")]
#endif
        Optimal,

        /// <summary>
        /// Операция сжатия должна завершиться как можно быстрее, даже если результирующий
        /// файл не будет сжат оптимально.
        /// </summary>
#if NET48
        [EnumItem("Быстрый", "Fastest")]
#else
        [EnumValue("Быстрый", "Fastest")]
#endif
        Fastest,

        /// <summary>
        /// Файл не требуется сжимать.
        /// </summary>
#if NET48
        [EnumItem("БезСжатия", "NoCompression")]
#else
        [EnumValue("БезСжатия", "NoCompression")]
#endif
        NoCompression
    }
}