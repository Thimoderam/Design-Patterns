using System;

namespace DesignPatternsBoekOpdrachten.Week_1
{
    internal class MuteQuack : QuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Silence...");
        }
    }
}