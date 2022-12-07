using Ilmhub.TestRunner;
using LogicsService;

namespace LogicsServiceTest;

[TestClass]
public class LogicServiceTest
{
    private readonly LogicService _logicService;

    public LogicServiceTest()
    {
        _logicService = new LogicService();
    }


    //TestMethodParameters is for method that has parameter(s)
    [TestMethod]
    [TestMethodParameters(13, 22, 33)]
    [TestMethodParameters(1, 2, 3)]
    [TestMethodParameters(1, 2, 5)]
    public void SumTest(int z, int b, int c)
    {
        if (c == _logicService.Sum(z, b))
            Console.WriteLine(" togri1");
        else
            Console.WriteLine(" notogri1");
    }

    [TestMethod]
    public void MinusTest()
    {
        if (2 == _logicService.Minus(3, 1))
            Console.WriteLine(" togri");
        else
            Console.WriteLine(" notogri");
        

        if (2 == _logicService.Minus(5, 3))
            Console.WriteLine(" togri");
        else
            Console.WriteLine(" notogri");
    }
}