using Ilmhub.TestRunner;
using LogicsService;

namespace LogicsServiceTest;

[TestClass] //test class
public class CalculatorServiceTest
{
    private readonly CalculatorService _calculatorService;

    public CalculatorServiceTest()
    {
        _calculatorService = new CalculatorService();
    }

    [TestMethod] // test method
    public void CalculateTest()
    {
        var result = _calculatorService.Calculate(2, 3, Operation.Plus);

        if (result == 5)
            Console.WriteLine("  true");
        else
            Console.WriteLine("  false");
    }
}