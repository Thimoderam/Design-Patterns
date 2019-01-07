using System;

namespace Oefentoets_Design_Patterns
{
    class TestClass
    {
        public TestClass()
        {
            BB8Droid droid = new BB8Droid();
            AstroMech mech = new BB8DroidAdapter(droid);
            mech.Diagnose();
            mech.Repair();
            mech.StoreHyperJumpCoord();
            Console.ReadLine();
        }
    }
}
