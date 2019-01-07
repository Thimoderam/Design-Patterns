using System;

namespace DesignPatternsBoekOpdrachten.Week_1
{
    internal class MallardDuck : Duck
    {
        public MallardDuck()
        {
            SetFlyBehavior(new FlyWithWings());
            SetQuackBehavior(new Quack());
        }

        public override void Display()
        {
            Console.WriteLine("A Mallard Duck is displayed!");
        }
    }
}