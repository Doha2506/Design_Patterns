using Coffee_Shop_System.Interfaces;

namespace Coffee_Shop_System.Services
{
    internal class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(ICoffee coffee) : base(coffee)
        {
        }

        public override double GetCost() => _coffee.GetCost() + 2.0;

        public override string GetDescription() => _coffee.GetDescription() + " , Milk";
    }
}
