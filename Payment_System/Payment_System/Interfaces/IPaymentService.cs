namespace Payment_System.Interfaces
{
    internal interface IPaymentService
    {
        void Pay(decimal amount);
        void SetStrategy(IPaymentStrategy paymentStrategy);
    }
}
