namespace Payment_System.Interfaces
{
    internal interface IPaymentStrategy
    {
        void ProcessPayment(decimal amount);
    }
}
