using DP.BridgePattern.Implementations;
using System;

namespace DP.BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Notification notification = new Notification();
            // Sending email without setting NotificationBuilder
            notification.SendEmail();
            notification.SendSms();

            // Web Service
            notification.NotificationBuilder = new WebService();
            notification.SendEmail();
            notification.SendSms();

            // Third Party Service
            notification.NotificationBuilder = new ThirdPartyService();
            notification.SendEmail();
            notification.SendSms();

            Console.ReadLine();
        }
    }

    #region Problematic Code (Unused interfaces and class, just to give an idea about the problem)

    interface INotificationWebService
    {
        void SendNotification();
    }

    class EmailWebService : INotificationWebService
    {
        public void SendNotification()
        {
            Console.WriteLine("Email sent through web service.");
        }
    }

    class SmsWebService : INotificationWebService
    {
        public void SendNotification()
        {
            Console.WriteLine("SMS sent through web service.");
        }
    }

    interface INotificationThirdPartyService
    {
        void SendNotification();
    }

    class EmailThirdPartyService : INotificationThirdPartyService
    {
        public void SendNotification()
        {
            Console.WriteLine("Email sent through third party service.");
        }
    }

    class SmsThirdPartyService : INotificationThirdPartyService
    {
        public void SendNotification()
        {
            Console.WriteLine("SMS sent through third party service.");
        }
    }

    #endregion
}
