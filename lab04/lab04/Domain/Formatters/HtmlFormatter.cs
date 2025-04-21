namespace lab04.Domain.Formatters;

public sealed class HtmlFormatter : IMessageFormatter
{
    public string Format(string message) => $"<html><body>{message}</body></html>";
}