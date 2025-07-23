using DesignPatternsInAction.FactoryMethod;

Console.WriteLine("== Notification Factory Method Example ==\n");

var emailSender = NotificationFactory.Create(NotificationType.Email);
emailSender.Send("user@example.com", "Welcome to our system!");

var smsSender = NotificationFactory.Create(NotificationType.Sms);
smsSender.Send("+994501112233", "Your verification code is 1234");

var pushSender = NotificationFactory.Create(NotificationType.Push);
pushSender.Send("user123", "You have a new message");