using Smartwyre.DeveloperTest.Data;
using Smartwyre.DeveloperTest.Types;
using Smartwyre.DeveloperTest.Types.RebateCalculations;

namespace Smartwyre.DeveloperTest.Services;

public class RebateService : IRebateService
{
    public CalculateRebateResult Calculate(CalculateRebateRequest request)
    {
        var rebateDataStore = new RebateDataStore();
        var productDataStore = new ProductDataStore();

        Rebate rebate = rebateDataStore.GetRebate(request.RebateIdentifier);
        Product product = productDataStore.GetProduct(request.ProductIdentifier);

        var result = new CalculateRebateResult();

        //if rebate is null
        if (rebate == null)
        {
            //set result failure, return
            result.Success = false;
            return result;
        }

        //instantiate RebateCalculation with IncentiveType
        var rebateCalculation = new RebateCalculation();

        //calculate rebate
        rebateCalculation.MakeRebateCalculation(rebate, product, request, ref result);

        if (result.Success)
        {
            var storeRebateDataStore = new RebateDataStore();
            storeRebateDataStore.StoreCalculationResult(rebate, rebateCalculation.Amount);
        }

        return result;
    }
}
