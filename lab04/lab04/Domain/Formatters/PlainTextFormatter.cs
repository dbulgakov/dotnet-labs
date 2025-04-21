namespace lab04.Domain.Formatters;

public sealed class PlainTextFormatter : IMessageFormatter
{
    public string Format(string message) => message;
}