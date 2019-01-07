using System;

namespace Oefentoets_Design_Patterns
{
    class StarFighter : AstroMech
    {
        public void StoreHyperJumpCoord()
        {
            Console.WriteLine("HyperJump coordinates stored by StarFighter.");
        }

        public void Diagnose()
        {
            Console.WriteLine("StarFighter Diagnosed.");
        }

        public void Repair()
        {
            Console.WriteLine("StarFighter Repaired.");
        }
    }
}
