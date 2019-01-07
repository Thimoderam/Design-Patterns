namespace Oefentoets_Design_Patterns
{
    class BB8DroidAdapter : AstroMech
    {
        private BB8Droid droid;

        public BB8DroidAdapter(BB8Droid droid)
        {
            this.droid = droid;
        }

        public void StoreHyperJumpCoord()
        {
            droid.SaveHyperJumpCoordinates();
        }

        public void Diagnose()
        {
            droid.PerformDiagnosis();
        }

        public void Repair()
        {
            droid.StartRepairs();
            droid.FinishRepairs();
        }
    }
}
