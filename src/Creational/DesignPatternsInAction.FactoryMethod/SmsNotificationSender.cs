namespace DesignPatternsInAction.FactoryMethod;

public class SmsNotificationSender : INotificationSender
{
    public void Send(string to, string message)
    {
        Console.WriteLine($"[SMS] To: {to}, Message: {message}");
    }
}
