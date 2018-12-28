using System;
using DesignPatternsCasusOpdrachten.Week_1.Origineel;

namespace DesignPatternsCasusOpdrachten.Week_1
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            //TestOrigineel();
            TestAangepast();
        }

        private static void TestOrigineel()
        {
            TestKassabon.TestKassabon1();
            TestKassabon.TestKassabon2();

            Console.WriteLine("Druk op Enter...");
            Console.ReadLine(); // Wacht tot de gebruiker op Enter drukt
        }

        private static void TestAangepast()
        {
            Aangepast.TestKassabon.TestKassabon1();
            Aangepast.TestKassabon.TestKassabon2();
            Aangepast.TestKassabon.TestKassabon3();
            Console.WriteLine("Druk op Enter...");
            Console.ReadLine(); // Wacht tot de gebruiker op Enter drukt
        }
    }
}