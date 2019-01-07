using System;
using DesignPatternsBoekOpdrachten.Week_3.Hoofdstuk_4.Pizza;

namespace DesignPatternsBoekOpdrachten.Week_3.Hoofdstuk_4.PizzaStore
{
    internal class CHPizzaStore : PizzaStore
    {
        protected override Pizza.Pizza CreatePizza(string item)
        {
            switch (item)
            {
                case "Cheese":
                    return new CHCheesePizza();
                case "Veggie":
                    return new CHVeggiePizza();
                case "Pepperoni":
                    return new CHPepperoniPizza();
                default: throw new Exception("Unknown Pizza!");
            }
        }
    }
}