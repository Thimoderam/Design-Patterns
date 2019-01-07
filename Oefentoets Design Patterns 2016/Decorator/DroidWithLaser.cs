using System;

namespace Oefentoets_Design_Patterns_2016
{
    class DroidWithLaser : ProtocolDroidDecorator
    {
        public DroidWithLaser(ProtocolDroid droid) : base(droid) { }
        public void ShootLaser()
        {
            Console.WriteLine("pew! pew! pew! pew!");
        }
    }
}
