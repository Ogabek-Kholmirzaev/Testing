using Moq;
using MoqApi.Services;
using AssemblyLoadEventArgs = System.AssemblyLoadEventArgs;
using Range = Moq.Range;

namespace MoqTest;

public class CalculatorServiceTest
{
    public Mock<ICalculatorService> CalculatorServiceMock;
    public ICalculatorService CalculatorService { get; set; }

    public CalculatorServiceTest()
    {
        CalculatorServiceMock = new Mock<ICalculatorService>();
        CalculatorService = CalculatorServiceMock.Object;
    }

    [Fact]
    public void GetNameTest()
    {
        CalculatorServiceMock.Setup(c => c.GetName()).Returns("GetNameMethod");

        Assert.Equal("getnamemethod", CalculatorService.GetName().ToLower());
    }

    [Fact]
    public void SumTest()
    {
        CalculatorServiceMock.Setup(c =>
            c.Sum(It.IsInRange<int>(0, 5, Range.Inclusive), It.IsInRange<int>(0, 10, Range.Inclusive))).Returns(7);

        Assert.Equal(7, CalculatorService.Sum(0, 0));
        Assert.Equal(7, CalculatorService.Sum(5, 10));
        Assert.Equal(7, CalculatorService.Sum(3, 7));

        Assert.Null(CalculatorService.Sum(-1, -1));
    }

    [Fact]
    public void TotalSumTest()
    {

    }
}