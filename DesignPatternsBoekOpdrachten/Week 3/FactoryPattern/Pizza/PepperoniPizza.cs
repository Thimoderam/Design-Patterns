using System;

namespace DesignPatternsBoekOpdrachten.Week_3.Hoofdstuk_4.Pizza
{
    public abstract class PepperoniPizza : Pizza
    {
        public virtual void Bake()
        {
            Console.Write("Baked like a pepperoni pizza");
        }

        public virtual void Box()
        {
            Console.Write("Boxed like a pepperoni pizza");
        }

        public virtual void Cut()
        {
            Console.Write("Cut like a pepperoni pizza");
        }

        public virtual void Prepare()
        {
            Console.Write("Prepared like a pepperoni pizza");
        }
    }
}