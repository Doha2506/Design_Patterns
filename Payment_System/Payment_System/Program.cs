using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Payment_System.Interfaces;
using Payment_System.Services;


var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddTransient<IPaymentService, PaymentService>();
        services.AddTransient<IPaymentStrategy, PayPalPayment>();
        services.AddTransient<IPaymentStrategy, CreditCardPayment>();
        services.AddTransient<IPaymentStrategy, BankTransferPayment>();
    })
    .Build();

var paymentService = host.Services.GetRequiredService<IPaymentService>();

bool isContinue = true;

while (isContinue) 
{
    Console.WriteLine("What way do you want to payment with (PayPal, CreditCard, BankTransfer)?");

    var paymentWay = Console.ReadLine();

    var isValidOption = true;
    decimal amount = 50;

    switch (paymentWay)
    {
        case "PayPal":
            paymentService.SetStrategy(new PayPalPayment());
            break;

        case "CreditCard":
            paymentService.SetStrategy(new CreditCardPayment());
            break;

        case "BankTransfer":
            paymentService.SetStrategy(new BankTransferPayment());
            break;

        default:
            Console.WriteLine("Please Write valid option");
            isValidOption = false;
            break;
    };

    if(isValidOption)   
        paymentService.Pay(amount);


    Console.WriteLine("Do you want try again (yes, no)?");
    var result = Console.ReadLine();

    if (result.Equals("no"))
    {
        break;
    }
}



