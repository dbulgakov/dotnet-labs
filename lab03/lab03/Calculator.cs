using System;

namespace lab03;

public class Calculator
{
    public double Divide(double a, double b)
    {
        if (b == 0)
            throw new DivideByZeroException("Division by zero is not allowed.");
        return a / b;
    }
}