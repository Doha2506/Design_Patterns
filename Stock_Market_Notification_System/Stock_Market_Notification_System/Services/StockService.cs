using Stock_Market_Notification_System.Interfaces;

namespace Stock_Market_Notification_System.Services
{
    internal class StockService : IStock
    {
        private List<IObserver> _observers;
        private decimal _price;

        public StockService()
        {
            _observers = new List<IObserver>(); 
            _price = 0;
        }

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers?.Remove(observer);
        }

        public void SetPrice(decimal price)
        {
            _price = price;
        }

        public void Notify()
        {
            foreach (var observer in _observers) 
            {
                observer.Update(_price);
            }
        }
    }
}
