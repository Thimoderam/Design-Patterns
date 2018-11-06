using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsBoekOpdrachten.Week_1
{
    class Quack : QuackBehavior
    {
        void QuackBehavior.Quack()
        {
            Console.WriteLine("Quack!");
        }
    }
}
