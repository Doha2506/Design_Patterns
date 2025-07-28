using Stock_Market_Notification_System.Interfaces;

namespace Stock_Market_Notification_System.Services
{
    internal class SMSSubscriber : IObserver
    {
        public void Update(decimal price)
        {
            Console.WriteLine("SMS - New stock price: " + price);
        }
    }
}
