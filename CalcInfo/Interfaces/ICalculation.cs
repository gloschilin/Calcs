namespace CalcInfo.Interfaces
{
    /// <summary>
    /// Интерфейс расчетчика
    /// </summary>
    /// <typeparam name="TInput"></typeparam>
    /// <typeparam name="TOutput"></typeparam>
    public interface ICalculation<in TInput, out TOutput>
        where TInput: ICalculationInfo
        where TOutput : IResultInfo
    {
        /// <summary>
        /// Сделать расчет
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        TOutput Calculate(TInput input);
    }
}
