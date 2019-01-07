namespace DesignPatternsBoekOpdrachten.Week2.Hoofdstuk_7
{
    public class TurkeyAdapter
    {
        //Should extend Duck so duck methods can be called aswell. However in this code Duck is not an interface.
        private readonly Turkey turkey;

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
            for (var i = 0; i < 5; i++)
                turkey.Fly();
        }
    }
}