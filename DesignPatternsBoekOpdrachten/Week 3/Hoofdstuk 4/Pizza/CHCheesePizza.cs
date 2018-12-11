using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsBoekOpdrachten.Week_3.Hoofdstuk_4
{
    class CHCheesePizza : CheesePizza
    {
        private string style = " in the Chicago style.\n";
        public override void Bake()
        {
            base.Bake();
            Console.Write(style);
        }

        public override void Box()
        {
            base.Box();
            Console.Write(style);
        }
        public override void Cut()
        {
            base.Cut();
            Console.Write(style);
        }
        public override void Prepare()
        {
            base.Prepare();
            Console.Write(style);
        }
    }
}
