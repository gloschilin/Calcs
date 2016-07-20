using CalcInfo.Interfaces;

namespace CalcInfo.Simple
{
    public class WageFacade : ICalculationFasade<WageAdaptorParameters, WageResultInfo>
    {
        private readonly WageAdaptor _adaptor;
        private readonly WageCalculation _calculation;

        public WageFacade(WageAdaptor adaptor, WageCalculation calculation)
        {
            _adaptor = adaptor;
            _calculation = calculation;
        }

        public WageResultInfo GetResult(WageAdaptorParameters adaptorParameters)
        {
            var parameters = _adaptor.GetCalculationInputModel(adaptorParameters);
            var calculationResult = _calculation.Calculate(parameters);
            return calculationResult;
        }
    }
}
