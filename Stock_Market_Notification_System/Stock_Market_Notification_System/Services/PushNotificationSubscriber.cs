using Stock_Market_Notification_System.Interfaces;

namespace Stock_Market_Notification_System.Services
{
    internal class PushNotificationSubscriber : IObserver
    {
        public void Update(decimal price)
        {
            Console.WriteLine("Push Notification Subscriber - New stock price: " + price);
        }
    }
}
