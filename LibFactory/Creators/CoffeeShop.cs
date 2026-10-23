namespace LibFactory
{
    public abstract class CoffeeShop
    {
        protected abstract ICoffee createCoffee(string type);

        public ICoffee orderCoffee(string type)
        {
            ICoffee coffee = createCoffee(type);
            coffee.Serve();
            return coffee;
        }
    }
}
