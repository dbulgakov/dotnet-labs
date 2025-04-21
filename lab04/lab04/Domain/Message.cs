namespace lab04.Domain;

public class Message(IMessageSender sender, IMessageFormatter formatter)
{
    public void Send(string message) => sender.Send(formatter.Format(message));
}