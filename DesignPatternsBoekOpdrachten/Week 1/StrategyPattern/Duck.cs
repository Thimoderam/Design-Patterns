using System;

namespace DesignPatternsBoekOpdrachten.Week_1
{
    public abstract class Duck
    {
        private FlyBehavior flyBehavior;
        private QuackBehavior quackBehavior;

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

        protected void SetQuackBehavior(QuackBehavior quackBehavior)
        {
            this.quackBehavior = quackBehavior;
        }
    }
}