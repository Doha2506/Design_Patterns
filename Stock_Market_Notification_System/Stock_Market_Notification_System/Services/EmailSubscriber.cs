using Stock_Market_Notification_System.Interfaces;

namespace Stock_Market_Notification_System.Services
{
    internal class EmailSubscriber : IObserver
    {
        public void Update(decimal price)
        {
            Console.WriteLine("Email - New stock price: " + price);
        }
    }
}
