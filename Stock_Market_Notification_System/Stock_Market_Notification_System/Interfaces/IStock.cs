namespace Stock_Market_Notification_System.Interfaces
{
    internal interface IStock 
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void SetPrice(decimal  price);
        void Notify();
    }
}
