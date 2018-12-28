using System;

namespace DesignPatternsBoekOpdrachten.Week_1
{
    internal class FlyRocketPowered : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with a rocket!");
        }
    }
}