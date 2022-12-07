using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicsService;

public class CalculatorService
{
    public int Calculate(int a, int b, Operation operation)
    {
        return operation switch
        {
            Operation.Plus => a + b,
            Operation.Minus => a - b,
            _ => throw new ArgumentOutOfRangeException(nameof(operation), operation, null)
        };
    }
}

public enum Operation
{
    Plus,
    Minus
}