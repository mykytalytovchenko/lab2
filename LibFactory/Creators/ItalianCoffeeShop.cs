using System;

namespace LibFactory
{
    public class ItalianCoffeeShop : CoffeeShop
    {
        protected override ICoffee createCoffee(string type)
        {
            switch (type)
            {
                case "espresso":
                    return new ItalianEspresso();
                case "latte":
                    return new ItalianLatte();
                case "americano":
                    return new ItalianAmericano();
                default:
                    throw new ArgumentException("Невідомий тип кави");
            }
        }
    }
}
