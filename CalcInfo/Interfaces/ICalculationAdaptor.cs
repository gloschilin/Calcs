namespace CalcInfo.Interfaces
{
    /// <summary>
    /// Адаптор сбора данных для расчетчика
    /// </summary>
    /// <typeparam name="TOutput"></typeparam>
    /// <typeparam name="TAddapterParams"></typeparam>
    public interface ICalculationAdaptor<out TOutput, in TAddapterParams>
        where TOutput : ICalculationInfo
    {
        //use Provider for create TOutput model

        TOutput GetCalculationInputModel(TAddapterParams adapterParams);
    }
}