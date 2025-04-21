using System;
using System.IO;
using lab03;

ConsoleHelpers.Log("Program started.");

ConsoleHelpers.Log("Starting Calculator test");
try
{
    var calc = new Calculator();
    var result = calc.Divide(new Random().NextInt64(1, 100), 0); // will throw
    ConsoleHelpers.Log($"Result: {result}");
}
catch (DivideByZeroException ex)
{
    ConsoleHelpers.Log($"[Calculator Error] {ex.Message}");
}
finally
{
    ConsoleHelpers.Log("[Calculator] Finished.");
}

ConsoleHelpers.Log("Starting FileReader test");
try
{
    var reader = new FileReader();
    var content = reader.ReadFile("nonexistent.txt"); // will throw
    ConsoleHelpers.Log($"File content: {content}");
}
catch (FileNotFoundException ex)
{
    ConsoleHelpers.Log($"[FileReader Error] {ex.Message}");
}
finally
{
    ConsoleHelpers.Log("[FileReader] Finished.");
}

ConsoleHelpers.Log("Starting ArrayProcessor test");
RunArrayTest("null", null);
RunArrayTest("empty", []);
RunArrayTest("valid", [10, 20, 30]);

ConsoleHelpers.Log("Program finished. Press any key to exit.");
Console.ReadKey();

void RunArrayTest(string label, int[]? input)
{
    ConsoleHelpers.Log($"Starting ArrayProcessor ({label})");

    try
    {
        var processor = new ArrayProcessor();
        var avg = processor.Process(input);
        ConsoleHelpers.Log($"Average: {avg}");
    }
    catch (ArgumentNullException ex)
    {
        ConsoleHelpers.Log($"[ArrayProcessor Error] Null input: {ex.Message}");
    }
    catch (ArgumentException ex)
    {
        ConsoleHelpers.Log($"[ArrayProcessor Error] Invalid input: {ex.Message}");
    }
    catch (Exception ex)
    {
        ConsoleHelpers.Log($"[ArrayProcessor Error] Unexpected: {ex.Message}");
    }
    finally
    {
        ConsoleHelpers.Log($"[ArrayProcessor - {label}] Finished.");
    }
}