using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCasusOpdrachten.Week_1.Origineel
{
    /// <summary>
    /// Testklasse voor het testen van Kassabon.
    /// </summary>
    class TestKassabon
    {
        public static void TestKassabon1()
        {
            Kassabon kassabon = new Kassabon();
            kassabon.VoegToe(new Pannenkoek("Naturelpannenkoek", 3.50));
            kassabon.VoegToe(new Pannenkoek("Kaaspannenkoek", 4.50));
            kassabon.VoegToe(new Pannenkoek("Spekpannenkoek", 5.75));
            kassabon.VoegToe(new Pannenkoek("Naturelpannenkoek", 3.50));
            kassabon.DrukBonAf();
        }

        public static void TestKassabon2()
        {
            Kassabon kassabon = new Kassabon();
            kassabon.VoegToe(new Pannenkoek("Kaas-spek-pannenkoek", 6.95));
            kassabon.DrukBonAf();
        }
    }
}
