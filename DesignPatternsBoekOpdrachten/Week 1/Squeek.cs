using System;

namespace DesignPatternsBoekOpdrachten.Week_1
{
    internal class Squeek : QuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeak!");
        }
    }
}