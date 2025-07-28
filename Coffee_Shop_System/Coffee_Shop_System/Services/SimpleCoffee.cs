using Coffee_Shop_System.Interfaces;

namespace Coffee_Shop_System.Services
{
    internal class SimpleCoffee : ICoffee
    {
        public double GetCost() => 5.0;
        
        public string GetDescription() => "Simple Coffee";
        
    }
}
