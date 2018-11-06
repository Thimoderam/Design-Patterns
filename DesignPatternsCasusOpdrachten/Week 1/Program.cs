using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCasusOpdrachten.Week_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestOrigineel();
            TestAangepast();
        }

        static void TestOrigineel()
        {
            DesignPatternsCasusOpdrachten.Week_1.Origineel.TestKassabon.TestKassabon1();
            DesignPatternsCasusOpdrachten.Week_1.Origineel.TestKassabon.TestKassabon2();

            Console.WriteLine("Druk op Enter...");
            Console.ReadLine(); // Wacht tot de gebruiker op Enter drukt
        }

        static void TestAangepast()
        {
            DesignPatternsCasusOpdrachten.Week_1.Aangepast.TestKassabon.TestKassabon1();
            DesignPatternsCasusOpdrachten.Week_1.Aangepast.TestKassabon.TestKassabon2();
            DesignPatternsCasusOpdrachten.Week_1.Aangepast.TestKassabon.TestKassabon3();
            Console.WriteLine("Druk op Enter...");
            Console.ReadLine(); // Wacht tot de gebruiker op Enter drukt
        }
    }
}
