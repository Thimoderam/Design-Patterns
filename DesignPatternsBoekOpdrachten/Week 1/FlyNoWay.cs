using System;

namespace DesignPatternsBoekOpdrachten.Week_1
{
    internal class FlyNoWay : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly!");
        }
    }
}