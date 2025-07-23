namespace DesignPatternsInAction.FactoryMethod;

public class PushNotificationSender : INotificationSender
{
    public void Send(string to, string message)
    {
        Console.WriteLine($"[Push] To: {to}, Message: {message}");
    }
}
