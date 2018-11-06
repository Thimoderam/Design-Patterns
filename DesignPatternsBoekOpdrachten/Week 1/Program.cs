using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsBoekOpdrachten.Week_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck model = new ModelDuck();
            model.PerformFly();
            model.PerformQuack();
            model.SetFlyBehavior(new FlyRocketPowered());
            model.PerformFly();
        }
    }
}
