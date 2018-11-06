using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsBoekOpdrachten.Week_1
{
    class ModelDuck : Duck
    {
        public ModelDuck()
        {
            SetFlyBehavior(new FlyNoWay());
            SetQuackBehavior(new Squeek());
        }
        public override void Display()
        {
            Console.WriteLine("Model Duck is now displayed!");
        }
    }
}
