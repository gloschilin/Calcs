using System;
using CalcInfo.Interfaces;

namespace CalcInfo.Simple
{
    public class WageCalculation : ICalculation<WageCalculationInfo, WageResultInfo>
    {
        public WageResultInfo Calculate(WageCalculationInfo input)
        {
            throw new NotImplementedException();
        }
    }
}