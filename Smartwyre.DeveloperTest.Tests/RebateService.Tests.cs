using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Smartwyre.DeveloperTest.Services;
using Smartwyre.DeveloperTest.Types;

namespace Smartwyre.DeveloperTest.Tests
{
    public class RebateServiceTests
    {
        public RebateServiceTests() { }

        [Fact]
        public void RebateCalculation_ReturnFalse()
        {
            //instantiate rebate service
            var rebateService = new RebateService();
            //instantiate CalculateRebateRequest
            var request = new CalculateRebateRequest();
            //calculate rebate
            var result = rebateService.Calculate(request);
            Assert.False(result.Success, "Calculation failed successfully");
        }

    }
}
