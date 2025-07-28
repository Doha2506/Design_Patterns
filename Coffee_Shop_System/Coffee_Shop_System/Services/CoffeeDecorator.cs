using Coffee_Shop_System.Interfaces;

namespace Coffee_Shop_System.Services
{
    internal abstract class CoffeeDecorator : ICoffee
    {
        protected ICoffee _coffee;

        public CoffeeDecorator(ICoffee coffee)
        {
            _coffee = coffee;
        }

        public abstract double GetCost();

        public abstract string GetDescription();
        
    }
}
