using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsBoekOpdrachten.Week_3.Hoofdstuk_4
{
    class NYPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string item)
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
