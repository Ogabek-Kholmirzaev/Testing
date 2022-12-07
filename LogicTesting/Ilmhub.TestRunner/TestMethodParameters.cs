namespace Ilmhub.TestRunner;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class TestMethodParameters : Attribute
{
    public TestMethodParameters(params object[] parameters)
    {
        Parameters = parameters;
    }

    public object[]? Parameters { get; set; }
}