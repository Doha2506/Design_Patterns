using Payment_System.Interfaces;

namespace Payment_System.Services
{
    internal class PaymentService : IPaymentService
    {
        private IPaymentStrategy _paymentStrategy;

        public PaymentService(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        public void SetStrategy(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        public void Pay(decimal amount)
        {
            _paymentStrategy.ProcessPayment(amount);
        }
    }
}
