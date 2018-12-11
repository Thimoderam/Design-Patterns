namespace DesignPatternsBoekOpdrachten.Week_3.Hoofdstuk_4
{
    public abstract class PizzaStore
    {
        public abstract Pizza CreatePizza(string item);
        public void OrderPizza(string item)
        {
            Pizza pizza = CreatePizza(item);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
        }

    }
}
