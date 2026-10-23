using System;

namespace LibFactory
{
    public class AmericanCoffeeShop : CoffeeShop
    {
        protected override ICoffee createCoffee(string type)
        {
            switch (type)
            {
                case "espresso":
                    return new AmericanEspresso();
                case "latte":
                    return new AmericanLatte();
                case "americano":
                    return new AmericanAmericano();
                default:
                    throw new ArgumentException("Невідомий тип кави");
            }
        }
    }
}
