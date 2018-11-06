using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsBoekOpdrachten.Week_1
{
    public abstract class Duck
    {
        FlyBehavior flyBehavior;
        QuackBehavior quackBehavior;
        public Duck()
        {
        }
        public abstract void Display();

        public void PerformFly()
        {
            flyBehavior.Fly();
        }

        public void PerformQuack()
        {
            quackBehavior.Quack();
        }
        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }

        public void SetFlyBehavior(FlyBehavior flyBehavior)
        {
            this.flyBehavior = flyBehavior;
        }

        public void SetQuackBehavior(QuackBehavior quackBehavior)
        {
            this.quackBehavior = quackBehavior;
        }

    }
}
