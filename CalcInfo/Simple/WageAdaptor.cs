using System;
using CalcInfo.Interfaces;

namespace CalcInfo.Simple
{
    public class WageAdaptor : ICalculationAdaptor<WageCalculationInfo, WageAdaptorParameters>
    {
        public WageCalculationInfo GetCalculationInputModel(WageAdaptorParameters adapterParams)
        {
            throw new NotImplementedException();
        }
    }
}
