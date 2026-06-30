using System;


namespace Lab_4
{
    interface INotificationService
    {
        public void sendNotification();
    }

    class EmailNotificationService : INotificationService
    {
         public void sendNotification()
        {
            Console.WriteLine("Message From Email");
        }
    }

    class SMSNotificationService : INotificationService
    {
        public void sendNotification()
        {
            Console.WriteLine("Message From SMS");
        }
    }
}
