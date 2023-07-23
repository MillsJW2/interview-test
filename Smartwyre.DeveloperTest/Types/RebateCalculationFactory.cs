using Smartwyre.DeveloperTest.Types.Interfaces;
using Smartwyre.DeveloperTest.Types.RebateCalculations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartwyre.DeveloperTest.Types
{
    public class RebateCalculationFactory
    {

        public IRebateCalculation CreateRebateCalculation(RebateCalculation rebateCalc)
        {
            //create derived type based on IncentiveType
            switch (rebateCalc.IncentiveType)
            {
                case IncentiveType.FixedCashAmount: return new FixedCashAmountRebateCalculation();
                case IncentiveType.FixedRateRebate: return new FixedRateRebateCalculation();
                case IncentiveType.AmountPerUom: return new AmountPerUomRebateCalculation();
                default: throw new Exception();
            }
        }
    }
}
