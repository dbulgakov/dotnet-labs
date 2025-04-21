using System;
using System.Linq;

namespace lab03;

public class ArrayProcessor
{
    public double Process(int[]? numbers)
    {
        if (numbers == null)
            throw new ArgumentNullException(nameof(numbers), "Array is null.");
        if (numbers.Length == 0)
            throw new ArgumentException("Array is empty.");
        return numbers.Average();
    }
}