namespace DesignPatternsBoekOpdrachten.Week_3.Hoofdstuk_4.PizzaStore
{
    public abstract class PizzaStore
    {
        protected abstract Pizza.Pizza CreatePizza(string item);

        public void OrderPizza(string item)
        {
            var pizza = CreatePizza(item);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
        }
    }
}