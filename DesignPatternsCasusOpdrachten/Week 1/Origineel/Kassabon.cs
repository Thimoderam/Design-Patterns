using System;
using System.Collections.Generic;

namespace DesignPatternsCasusOpdrachten.Week_1.Origineel
{
    public class Kassabon
    {
        private readonly List<Pannenkoek> pannenkoeken;

        /// <summary>
        ///     Deze klasse realiseert een eenvoudige kassabon voor ons
        ///     pannenkoekenhuis, en toont hoe het Strategy design pattern kan worden
        ///     gebruikt.
        ///     Introductie:
        ///     Met enige regelmaat worden er nieuwe kortingsacties bedacht,
        ///     waardoor telkens het algoritme voor het berekenen van korting
        ///     in deze Kassabon klasse moet worden aangepast.
        ///     Opgave:
        ///     Gebruik het Strategy pattern om de algoritmen af te splitsen in
        ///     aparte klassen onder een gemeenschappelijk interface.
        /// </summary>
        public Kassabon()
        {
            pannenkoeken = new List<Pannenkoek>();
        }

        /// <summary>
        ///     Voegt een pannenkoek toe aan de kassabon
        /// </summary>
        /// <param name="p">De Pannenkoek om toe te voegen</param>
        public void VoegToe(Pannenkoek p)
        {
            pannenkoeken.Add(p);
        }

        /// <summary>
        ///     Drukt een kassabon af op de console, met daarin opgenomen
        ///     de beschrijving en prijs van elke pannenkoek op de rekening,
        ///     de totaalprijs (= som van de prijzen van alle pannenkoeken),
        ///     de korting (= bedrag dat van de totaalprijs zal worden afgetrokken),
        ///     en het eindbedrag (= totaalprijs - korting)
        /// </summary>
        public void DrukBonAf()
        {
            Console.WriteLine("\nKassabon");
            foreach (var p in pannenkoeken) Console.WriteLine("{0} : \t{1,6:F2}", p.Beschrijving(), p.Prijs());
            Console.WriteLine("Totaalprijs :  \t{0,6:F2}", Totaalprijs());
            Console.WriteLine("Korting     : -\t{0,6:F2}", Korting());
            Console.WriteLine("Eindbedrag  =  \t{0,6:F2}", Eindbedrag());
        }

        /// <summary>
        ///     Geeft de som van de prijzen van alle pannenkoeken op de kassabon
        /// </summary>
        /// <returns></returns>
        private double Totaalprijs()
        {
            var totaalprijs = 0.0;
            foreach (var p in pannenkoeken) totaalprijs += p.Prijs();
            return totaalprijs;
        }

        /// <summary>
        ///     Geeft de totaalprijs minus de korting
        /// </summary>
        /// <returns></returns>
        private double Eindbedrag()
        {
            var eindbedrag = Totaalprijs() - Korting();
            if (eindbedrag < 0.0) eindbedrag = 0.0;
            return eindbedrag;
        }

        /// <summary>
        ///     Berekent de korting, volgens de actuele kortingsactie(s)
        ///     Deze kortingsregels veranderen regelmatig, telkens als nieuwe
        ///     kortingsacties worden bedacht.
        /// </summary>
        /// <returns></returns>
        private double Korting()
        {
            // Hier staat de code voor het berekenen van de korting volgens de actuele kortingsactie
            var korting = Totaalprijs() * 0.1; // 10% korting op de totaalprijs
            //korting = pannenkoeken[0].Prijs() * 0.5; // Eerste pannenkoek voor de halve prijs
            // Vul hier zelf de gevraagde kortingsacties aan...
            return korting;
        }
    }
}