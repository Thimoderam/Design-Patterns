using System;
using DesignPatternsBoekOpdrachten.Week_3.Hoofdstuk_4.Pizza;

namespace DesignPatternsBoekOpdrachten.Week_3.Hoofdstuk_4.PizzaStore
{
    internal class NYPizzaStore : PizzaStore
    {
        protected override Pizza.Pizza CreatePizza(string item)
        {
            switch (item)
            {
                case "Cheese":
                    return new NYCheesePizza();
                case "Veggie":
                    return new NYVeggiePizza();
                case "Pepperoni":
                    return new NYPepperoniPizza();
                default: throw new Exception("Unknown Pizza!");
            }
        }
    }
}