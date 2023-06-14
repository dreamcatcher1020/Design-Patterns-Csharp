using DP.BridgePattern.Contracts;
using System;

namespace DP.BridgePattern.Implementations
{
    class WebService : INotificationBuilder
    {
        public void SendEmail()
    {
        Console.WriteLine("Email sent through web service.");
    }

    public void SendSms()
    {
        Console.WriteLine("SMS sent through web service.");
    }
}
}
