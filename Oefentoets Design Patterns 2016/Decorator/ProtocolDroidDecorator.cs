namespace Oefentoets_Design_Patterns_2016
{
    class ProtocolDroidDecorator : ProtocolDroid
    {
        protected ProtocolDroid droid;
        public ProtocolDroidDecorator(ProtocolDroid droid)
        {
            this.droid = droid;
        }

        public new void Greet()
        {
            droid.Greet();
        }
    }
}
