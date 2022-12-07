using Ilmhub.TestRunner;
using LogicsService;

namespace LogicsServiceTest;

[TestClass]
public class NimaServiceTest
{
    [TestMethod]
    [TestMethodParameters("Nima")]
    public void ShowTest(string p)
    {
        var nimaService = new NimaService();
        var result = nimaService.Show();

        if (p == result)
            Console.WriteLine(" result togri");
        else if ("nima" == result)
            Console.WriteLine(" result notogri");

        if (4 == result.Count())
            Console.WriteLine(" belgi count togri");
        else 
            Console.WriteLine(" belgi count notogri");
    }
}