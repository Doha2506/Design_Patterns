using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Stock_Market_Notification_System.Interfaces;
using Stock_Market_Notification_System.Services;

var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddTransient<IStock, StockService>();
    })
    .Build();

var stockService = new StockService();

var email = new EmailSubscriber();

var sms = new SMSSubscriber();

stockService.Attach(email);
stockService.Attach(sms);

stockService.SetPrice(10);

stockService.Notify();

stockService.SetPrice(20);

stockService.Notify();

var noti = new PushNotificationSubscriber();

stockService.Attach(noti);

stockService.Detach(sms);

stockService.Notify();


