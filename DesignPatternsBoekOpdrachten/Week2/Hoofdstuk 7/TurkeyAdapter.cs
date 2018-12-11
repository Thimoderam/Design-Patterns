namespace DesignPatternsBoekOpdrachten.Week2.Hoofdstuk_7
{
    class TurkeyAdapter
    {
        //Should extend Duck so duck methods can be called aswell. However in this code Duck is not an interface.
        private Turkey turkey;

        public TurkeyAdapter(Turkey turkey)
        {
            this.turkey = turkey;
        }

        public void Quack()
        {
            turkey.Gobble();
        }
        public void Fly()
        {
            for (int i = 0; i < 5; i++)
                turkey.Fly();
        }
    }
}
