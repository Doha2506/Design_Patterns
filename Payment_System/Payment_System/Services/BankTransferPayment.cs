using Payment_System.Interfaces;

namespace Payment_System.Services
{
    internal class BankTransferPayment : IPaymentStrategy
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine("Pay " + amount + " Using Bank Transfer");
        }
    }
}
