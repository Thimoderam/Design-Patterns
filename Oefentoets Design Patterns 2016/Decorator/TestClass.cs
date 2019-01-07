using System;

namespace Oefentoets_Design_Patterns_2016
{
    class TestClass
    {
        public TestClass()
        {
            ProtocolDroid protocolDroid = new ProtocolDroid();
            DroidWithLaser droid = new DroidWithLaser(protocolDroid);
            droid.Greet();
            droid.ShootLaser();
            Console.ReadLine();
        }
    }

}


