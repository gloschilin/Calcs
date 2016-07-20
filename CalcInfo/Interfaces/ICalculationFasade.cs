namespace CalcInfo.Interfaces
{
    /// <summary>
    /// Фасад расчета
    /// </summary>
    /// <typeparam name="TAdaptorInput"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    public interface ICalculationFasade<in TAdaptorInput, out TResult>
        where TResult : ICalculationInfo
    {
        TResult GetResult(TAdaptorInput adaptorParameters);
    }

    
}
