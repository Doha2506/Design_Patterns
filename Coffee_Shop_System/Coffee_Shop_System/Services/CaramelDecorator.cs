using Coffee_Shop_System.Interfaces;

namespace Coffee_Shop_System.Services
{
    internal class CaramelDecorator : CoffeeDecorator
    {
        public CaramelDecorator(ICoffee coffee) : base(coffee)
        {
        }

        public override double GetCost() => _coffee.GetCost() + 10.0;

        public override string GetDescription() => _coffee.GetDescription() + " , Caramel";
    }
}
