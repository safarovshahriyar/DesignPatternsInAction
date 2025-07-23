namespace DesignPatternsInAction.FactoryMethod;

public class EmailNotificationSender : INotificationSender
{
    public void Send(string to, string message)
    {
        Console.WriteLine($"[Email] To: {to}, Message: {message}");
    }
}
