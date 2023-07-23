using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Smartwyre.DeveloperTest.Types.Interfaces;

namespace Smartwyre.DeveloperTest.Types.RebateCalculations
{
    public class FixedRateRebateCalculation : RebateCalculation, IRebateCalculation
    {
        public void CalculateRebate(Rebate rebate, Product product, CalculateRebateRequest request, ref CalculateRebateResult result)
        {
            //if product is null or does not support incentive type
            if (product == null || !product.SupportedIncentives.HasFlag(SupportedIncentiveType.FixedRateRebate))
            {
                result.Success = false;
                return;
            }

            //if percentage, price, or volume is 0 return failure
            if (rebate.Percentage == 0 || product.Price == 0 || request.Volume == 0)
            {
                result.Success = false;
                return;
            }

            //calculate rebate
            Amount += product.Price * rebate.Percentage * request.Volume;
            result.Success = true;

        }
    }
}
