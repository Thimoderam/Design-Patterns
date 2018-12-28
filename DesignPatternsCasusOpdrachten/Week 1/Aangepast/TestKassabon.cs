using System;

namespace DesignPatternsCasusOpdrachten.Week_1.Aangepast
{
    public class TestKassabon
    {
        public static void TestKassabon1()
        {
            Console.WriteLine(@"------------------------------------------------------------");
            Console.WriteLine("Naturel voor 2 euro");
            Console.WriteLine(@"------------------------------------------------------------");
            var kassabon = new Kassabon(new VijftienProcentOpTotaalKorting());
            kassabon.VoegToe(new Pannenkoek("Naturelpannenkoek", 3.50));
            kassabon.VoegToe(new Pannenkoek("Kaaspannenkoek", 4.50));
            kassabon.VoegToe(new Pannenkoek("Spekpannenkoek", 5.75));
            kassabon.VoegToe(new Pannenkoek("Naturelpannenkoek", 3.50));
            kassabon.SetKortingsActie(new NaturelVoorTweeEuroKorting()); //verandering van het type korting op runtime.
            kassabon.DrukBonAf();
        }

        public static void TestKassabon2()
        {
            Console.WriteLine(@"------------------------------------------------------------");
            Console.WriteLine(Environment.NewLine + "15 procent op totaal");
            Console.WriteLine(@"------------------------------------------------------------");
            var kassabon = new Kassabon(new VijftienProcentOpTotaalKorting());
            kassabon.VoegToe(new Pannenkoek("Kaas-spek-pannenkoek", 6.95));
            kassabon.DrukBonAf();
        }

        public static void TestKassabon3()
        {
            Console.WriteLine(@"------------------------------------------------------------");
            Console.WriteLine(Environment.NewLine + "tweede halve prijs");
            Console.WriteLine(@"------------------------------------------------------------");
            var kassabon = new Kassabon(new TweedeHalvePrijsKorting());
            kassabon.VoegToe(new Pannenkoek("Kaas-spek-pannenkoek", 6.95));
            kassabon.VoegToe(new Pannenkoek("Spekpannenkoek", 5.75));
            kassabon.DrukBonAf();
        }
    }
}