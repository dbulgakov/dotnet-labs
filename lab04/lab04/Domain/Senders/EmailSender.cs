namespace lab04.Domain.Senders;

public sealed class EmailSender : IMessageSender
{
    public void Send(string message) => Logger.Instance.Log($"[Email] {message}");
}