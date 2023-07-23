using Smartwyre.DeveloperTest.Types.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartwyre.DeveloperTest.Types.RebateCalculations
{
    public class AmountPerUomRebateCalculation : RebateCalculation, IRebateCalculation
    {
        public void CalculateRebate(Rebate rebate, Product product, CalculateRebateRequest request, ref CalculateRebateResult result)
        {
            //if product is null or does not support incentive type
            if (product == null || !product.SupportedIncentives.HasFlag(SupportedIncentiveType.AmountPerUom))
            {
                result.Success = false;
                return;
            }

            //if rebate amount is 0 or request volume is 0 return failure
            if (rebate.Amount == 0 || request.Volume == 0)
            {
                result.Success = false;
                return;
            }

            //calculate rebate
            Amount += rebate.Amount * request.Volume;
            result.Success = true;
        }
    }
}
