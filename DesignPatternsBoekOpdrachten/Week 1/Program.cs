using DesignPatternsBoekOpdrachten.Week2.Hoofdstuk2;
using System;

namespace DesignPatternsBoekOpdrachten.Week_1
{
    class Program
    {
        static void Main(string[] args)
        {
            RunWeek2();
            Console.ReadKey();
        }

        static void RunWeek1()
        {
            Duck model = new ModelDuck();
            model.PerformFly();
            model.PerformQuack();
            model.SetFlyBehavior(new FlyRocketPowered());
            model.PerformFly();
        }

        static void RunWeek2()
        {
            WeatherData data = new WeatherData();
            new CurrentConditionsDisplay(data);
            new StatisticsDisplay(data);
            new ForecastDisplay(data);
            data.Temperature = 22.7;
        }
    }
}
