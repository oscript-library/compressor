using ScriptEngine.Machine;

namespace OscriptCompressor
{
    internal interface ICompressor
    {
        /// <summary>
        /// Упаковывает данные.
        /// </summary>
        /// <param name="data">Исходные данные</param>
        /// <param name="outputStream">Поток для записи упакованных данных</param>
        /// <returns>Упакованные двоичные данные, когда не указан поток для записи</returns>
        IValue Compress(IValue data, IValue outputStream = null);

        /// <summary>
        /// Распаковывает данные.
        /// </summary>
        /// <param name="data">Упакованные данные</param>
        /// <param name="outputStream">Поток для записи распакованных данных</param>
        /// <returns>Распакованные двоичные данные, когда не указан поток для записи</returns>
        IValue Decompress(IValue data, IValue outputStream = null);
    }
}
