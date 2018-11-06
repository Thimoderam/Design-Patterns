using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsBoekOpdrachten.Week_1
{
    class MuteQuack : QuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Silence...");
        }
    }
}
