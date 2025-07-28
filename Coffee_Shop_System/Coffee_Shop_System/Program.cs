using Coffee_Shop_System.Interfaces;
using Coffee_Shop_System.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddTransient<ICoffee, SimpleCoffee>();
    })
    .Build();

ICoffee coffee = host.Services.GetRequiredService<ICoffee>(); // Get the base coffee from DI

Console.WriteLine("Choose which type of coffee you prefer ?");
Console.WriteLine("1- Simple 2- Milk 3- Sugared 4- Carmael 5- WhippedCream " +
    "6- Milk_Caramel 7- Milk_Carmel_Sugar 8- Milk_Caramel_Sugar_WhippedCream");

var orderType = Console.ReadLine();

switch (orderType?.ToLower())
{
    case "milk":
        coffee = new MilkDecorator(coffee);
        break;
    case "sugared":
        coffee = new SugarDecorator(coffee);
        break;
    case "carmael":
        coffee = new CaramelDecorator(coffee);
        break;
    case "whippedcream":
        coffee = new WhippedCreamDecorator(coffee);
        break;
    case "milk_caramel":
        coffee = new MilkDecorator(coffee);
        coffee = new CaramelDecorator(coffee);
        break;
    case "milk_carmel_sugar":
        coffee = new MilkDecorator(coffee);
        coffee = new CaramelDecorator(coffee);
        coffee = new SugarDecorator(coffee);
        break;
    case "milk_caramel_sugar_whippedcream":
        coffee = new MilkDecorator(coffee);
        coffee = new CaramelDecorator(coffee);
        coffee = new SugarDecorator(coffee);
        coffee = new WhippedCreamDecorator(coffee);
        break;
    // Add more cases for different combinations
    default:
        // If no specific decorators, return the simple coffee
        break;
}

coffee = new ToGoCupDecorator(coffee);

Console.WriteLine("Type : " + coffee.GetDescription()); // Should show: Simple Coffee, Milk, Caramel with cup
Console.WriteLine("Price : " + coffee.GetCost()); // Should reflect added costs
