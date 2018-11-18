using DesignPatternsBoekOpdrachten.Week_1;
using DesignPatternsBoekOpdrachten.Week2.Hoofdstuk_3;
using DesignPatternsBoekOpdrachten.Week2.Hoofdstuk2;
using System;

namespace DesignPatternsBoekOpdrachten
{
    class Program
    {
        static void Main(string[] args)
        {
            RunHoofdstuk3();
            Console.ReadKey();
        }

        static void RunHoofdstuk1()
        {
            Duck model = new ModelDuck();
            model.PerformFly();
            model.PerformQuack();
            model.SetFlyBehavior(new FlyRocketPowered());
            model.PerformFly();
        }

        static void RunHoofdstuk2()
        {
            WeatherData data = new WeatherData();
            new CurrentConditionsDisplay(data);
            new StatisticsDisplay(data);
            new ForecastDisplay(data);
            data.Temperature = 22.7;
        }

        static void RunHoofdstuk3()
        {
            Beverage beverage = new Espresso();
            Console.WriteLine($"{beverage.GetDescription()} ${beverage.Cost()}");
            Beverage beverage1 = new HouseBlend();
            beverage1 = new Mocha(beverage1);
            beverage1 = new Mocha(beverage1);
            beverage1 = new Whip(beverage1);
            Console.WriteLine($"{beverage1.GetDescription()} ${beverage1.Cost()}");

        }
    }
}
