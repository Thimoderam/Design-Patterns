using System;

namespace DesignPatternsBoekOpdrachten.Week_1
{
    internal class Quack : QuackBehavior
    {
        void QuackBehavior.Quack()
        {
            Console.WriteLine("Quack!");
        }
    }
}