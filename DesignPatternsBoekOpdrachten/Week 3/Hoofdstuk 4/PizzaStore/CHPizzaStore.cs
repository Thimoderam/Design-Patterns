using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsBoekOpdrachten.Week_3.Hoofdstuk_4
{
    class CHPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string item)
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
