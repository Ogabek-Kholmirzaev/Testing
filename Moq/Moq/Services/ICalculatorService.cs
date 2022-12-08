namespace MoqApi.Services;

public interface ICalculatorService
{
    public string GetName();
    public int? Sum(int a, int b);
    public int TotalSum { get; set; }
}