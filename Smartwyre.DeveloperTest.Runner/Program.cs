using System;
using Smartwyre.DeveloperTest.Tests;
using Smartwyre.DeveloperTest.Services;
using System.Collections.Generic;

namespace Smartwyre.DeveloperTest.Runner;

class Program
{
    static void Main(string[] args)
    {

        var rebateServiceTests = new RebateServiceTests();
        rebateServiceTests.RebateCalculation_ReturnFalse();
        rebateServiceTests.UnimplementedRebateCalculationThrowsException_ReturnTrue();
    }
}
