namespace DesignPatternsBoekOpdrachten.Week2.Hoofdstuk_3
{
    abstract class Beverage
    {
        protected string description = "Unknown beverage";

        public virtual string GetDescription()
        {
            return description;
        }

        public abstract double Cost();

    }
}
