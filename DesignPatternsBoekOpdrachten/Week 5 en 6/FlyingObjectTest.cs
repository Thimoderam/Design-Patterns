using System;

namespace DesignPatternsBoekOpdrachten.Week_5_en_6
{
    public class FlyingObjectTest
    {
        public FlyingObjectTest()
        {
            FlyingObjectBuilder spitfireBuilder = new SpitfireBuilder();
            var spitfireDirector = new FlyingObjectDirector(spitfireBuilder);
            spitfireDirector.CreateSpitFire();
            var spitfire = spitfireBuilder.GetFlyingObject();
            Console.WriteLine(spitfire.ToString());
        }
    }
}