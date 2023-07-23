using Smartwyre.DeveloperTest.Types.Interfaces;

namespace Smartwyre.DeveloperTest.Types;

public class RebateCalculation : IRebateCalculation
{
    public int Id { get; set; }
    public string Identifier { get; set; }
    public string RebateIdentifier { get; set; }
    public IncentiveType IncentiveType { get; set; }
    public decimal Amount { get; set; }

    public virtual void CalculateRebate(Rebate rebate, Product product, CalculateRebateRequest request, ref CalculateRebateResult result)
    {
        throw new System.NotImplementedException();
    }

    public void MakeRebateCalculation(Rebate rebate, Product product,
        CalculateRebateRequest request, ref CalculateRebateResult result)
    {
        //instantiate rebate calculation factory
        var rebateFactory = new RebateCalculationFactory();

        //Calculate Rebate
        rebateFactory.CreateRebateCalculation(this).CalculateRebate(rebate, product, request, ref result);
    }



}
