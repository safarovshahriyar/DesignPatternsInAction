namespace DesignPatternsInAction.FactoryMethod;

public interface INotificationSender
{
    void Send(string to, string message);
}
