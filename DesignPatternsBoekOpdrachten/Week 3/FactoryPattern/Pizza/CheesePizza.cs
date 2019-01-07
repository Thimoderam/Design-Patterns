using System;

namespace DesignPatternsBoekOpdrachten.Week_3.Hoofdstuk_4.Pizza
{
    public abstract class CheesePizza : Pizza
    {
        public virtual void Bake()
        {
            Console.Write("Baked like a cheese pizza");
        }

        public virtual void Box()
        {
            Console.Write("Boxed like a cheese pizza");
        }

        public virtual void Cut()
        {
            Console.Write("Cut like a cheese pizza");
        }

        public virtual void Prepare()
        {
            Console.Write("Prepared like a cheese pizza");
        }
    }
}