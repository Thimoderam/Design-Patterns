using System;

namespace DesignPatternsBoekOpdrachten.Week_1
{
    internal class FlyWithWings : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying!");
        }
    }
}