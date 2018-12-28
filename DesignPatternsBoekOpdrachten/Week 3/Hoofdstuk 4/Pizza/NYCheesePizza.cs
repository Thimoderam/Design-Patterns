﻿using System;

namespace DesignPatternsBoekOpdrachten.Week_3.Hoofdstuk_4.Pizza
{
    internal class NYCheesePizza : CheesePizza
    {
        private readonly string style = " in the New York style.\n";

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