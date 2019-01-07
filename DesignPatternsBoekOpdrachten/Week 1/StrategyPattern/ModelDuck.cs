using System;

namespace DesignPatternsBoekOpdrachten.Week_1
{
    internal class ModelDuck : Duck
    {
        public ModelDuck()
        {
            SetFlyBehavior(new FlyNoWay());
            SetQuackBehavior(new Squeek());
        }

        public override void Display()
        {
            Console.WriteLine("Model Duck is now displayed!");
        }
    }
}