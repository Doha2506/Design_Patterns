using Coffee_Shop_System.Interfaces;

namespace Coffee_Shop_System.Services
{
    internal class WhippedCreamDecorator : CoffeeDecorator
    {
        public WhippedCreamDecorator(ICoffee coffee) : base(coffee)
        {
        }

        public override double GetCost() => _coffee.GetCost() + 7.0;

        public override string GetDescription() => _coffee.GetDescription() + " , WhippedCream";    
        
    }
}
