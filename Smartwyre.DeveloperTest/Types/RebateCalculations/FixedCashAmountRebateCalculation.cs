using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Smartwyre.DeveloperTest.Types.Interfaces;


namespace Smartwyre.DeveloperTest.Types.RebateCalculations
{
    public class FixedCashAmountRebateCalculation : RebateCalculation, IRebateCalculation
    {
        public void CalculateRebate(Rebate rebate, Product product, CalculateRebateRequest request, ref CalculateRebateResult result)
        {
            //if product is null or does not support incentive type
            if (product == null || !product.SupportedIncentives.HasFlag(SupportedIncentiveType.FixedCashAmount))
            {
                result.Success = false;
                return;
            }

            // if rebate amount is 0 return failure
            if (rebate.Amount == 0)
            {
                result.Success = false;
                return;
            }

            //calculate rebate
            Amount = rebate.Amount;
            result.Success = true;
        }
    }
}
