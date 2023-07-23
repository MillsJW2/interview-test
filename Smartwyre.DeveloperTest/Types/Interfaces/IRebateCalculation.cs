using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartwyre.DeveloperTest.Types.Interfaces
{
    public interface IRebateCalculation
    {
        public void CalculateRebate(Rebate rebate, Product product, CalculateRebateRequest request, ref CalculateRebateResult result);
    }
}
