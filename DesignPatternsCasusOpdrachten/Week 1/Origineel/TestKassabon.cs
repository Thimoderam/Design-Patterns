namespace DesignPatternsCasusOpdrachten.Week_1.Origineel
{
    /// <summary>
    ///     Testklasse voor het testen van Kassabon.
    /// </summary>
    internal class TestKassabon
    {
        public static void TestKassabon1()
        {
            var kassabon = new Kassabon();
            kassabon.VoegToe(new Pannenkoek("Naturelpannenkoek", 3.50));
            kassabon.VoegToe(new Pannenkoek("Kaaspannenkoek", 4.50));
            kassabon.VoegToe(new Pannenkoek("Spekpannenkoek", 5.75));
            kassabon.VoegToe(new Pannenkoek("Naturelpannenkoek", 3.50));
            kassabon.DrukBonAf();
        }

        public static void TestKassabon2()
        {
            var kassabon = new Kassabon();
            kassabon.VoegToe(new Pannenkoek("Kaas-spek-pannenkoek", 6.95));
            kassabon.DrukBonAf();
        }
    }
}