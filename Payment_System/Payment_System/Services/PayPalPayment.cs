using Payment_System.Interfaces;

namespace Payment_System.Services
{
    internal class PayPalPayment : IPaymentStrategy
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine("Pay " + amount + " Using PayPal");
        }
    }
}
