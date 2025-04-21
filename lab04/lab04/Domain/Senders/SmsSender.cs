namespace lab04.Domain.Senders;

public class SmsSender : IMessageSender
{
    public void Send(string message) => Logger.Instance.Log($"[SMS] {message}");
}