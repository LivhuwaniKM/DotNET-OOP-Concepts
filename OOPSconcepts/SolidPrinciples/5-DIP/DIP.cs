namespace OOPSconcepts.SolidPrinciples._5_DIP
{
    // Dependency Inversion Responsibilty
    public class DIP
    {
        public static void Main()
        {
            INotificationService emailService = new EmailNotificationService();
            NotificationServiceClient client1 = new(emailService);
            client1.SendNotification("Hello via email");

            INotificationService smsService = new SmsNotificationService();
            NotificationServiceClient client2 = new(smsService);
            client2.SendNotification("Hello via SMS");

            INotificationService pushNotification = new PushNotificationService();
            NotificationServiceClient client3 = new(pushNotification);
            client3.SendNotification("Hello via psuh notification");
        }
    }

    public interface INotificationService
    {
        void SendNotification(string message);
    }

    public class EmailNotificationService : INotificationService
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Sending email notification: {message}");
        }
    }

    public class SmsNotificationService : INotificationService
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Sending SMS notification: {message}");
        }
    }

    public class PushNotificationService : INotificationService
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Sending push notification: {message}");
        }
    }

    public class NotificationServiceClient
    {
        private readonly INotificationService _notificationService;

        public NotificationServiceClient(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public void SendNotification(string message)
        {
            _notificationService.SendNotification(message);
        }
    }
}
