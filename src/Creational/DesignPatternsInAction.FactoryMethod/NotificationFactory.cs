namespace DesignPatternsInAction.FactoryMethod;

public static class NotificationFactory
{
    public static INotificationSender Create(NotificationType type)
    {
        return type switch
        {
            NotificationType.Email => new EmailNotificationSender(),
            NotificationType.Sms => new SmsNotificationSender(),
            NotificationType.Push => new PushNotificationSender(),
            _ => throw new NotSupportedException($"Notification type '{type}' is not supported")
        };
    }
}
