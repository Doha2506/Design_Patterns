namespace Stock_Market_Notification_System.Interfaces
{
    internal interface IObserver
    {
        void Update(decimal price);
    }
}
