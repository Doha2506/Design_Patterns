
using Payment_System.Interfaces;

namespace Payment_System.Services
{
    internal class CreditCardPayment : IPaymentStrategy
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine("Pay " + amount + " Using Credit Card");
        }
    }
}
