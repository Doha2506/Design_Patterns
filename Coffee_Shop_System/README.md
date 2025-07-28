🧠 Scenario: Coffee Shop Customization System

You're building a system for a coffee shop where customers can order coffee and customize it with different add-ons like milk, sugar, whipped cream, caramel, etc.

The goal is to allow flexible combinations of add-ons without creating a huge inheritance hierarchy like MilkCoffeeWithSugarAndCaramel.

🎯 Objectives:

Apply the Decorator Pattern to allow dynamic addition of features (add-ons) to a base coffee order.

Follow the Open-Closed Principle — allow extension without modifying existing code.

✅ Requirements:

Create a base interface

Implement a base class

Create abstract Decorator class that implements ICoffee and wraps another ICoffee.

Implement concrete decorators like:

MilkDecorator

SugarDecorator

WhippedCreamDecorator

CaramelDecorator

Each should add to the description and cost.

Test different combinations:

ICoffee order = new CaramelDecorator(new MilkDecorator(new SimpleCoffee()));
Console.WriteLine(order.GetDescription()); // Should show: Simple Coffee, Milk, Caramel
Console.WriteLine(order.GetCost()); // Should reflect added costs

🔄 Bonus Challenge:

Add a ToGoCupDecorator that adds a fixed cost and modifies the description to indicate it’s in a to-go cup.