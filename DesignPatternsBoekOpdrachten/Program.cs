using DesignPatternsBoekOpdrachten.Week_1;
using DesignPatternsBoekOpdrachten.Week_3.Hoofdstuk_4;
using DesignPatternsBoekOpdrachten.Week_3.Hoofdstuk_5;
using DesignPatternsBoekOpdrachten.Week2.Hoofdstuk_3;
using DesignPatternsBoekOpdrachten.Week2.Hoofdstuk_7;
using DesignPatternsBoekOpdrachten.Week2.Hoofdstuk2;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatternsBoekOpdrachten
{
    class Program
    {
        static void Main(string[] args)
        {
            RunHoofdstuk5();
            Console.ReadKey();
        }

        static void RunHoofdstuk1()
        {
            Week_1.Duck model = new ModelDuck();
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

        static void RunHoofdstuk7()
        {
            Week2.Hoofdstuk_7.Duck duck = new Week2.Hoofdstuk_7.Duck();
            Turkey turkey = new Turkey();
            TurkeyAdapter adapter = new TurkeyAdapter(turkey);   //Should be of type Duck if duck was the implemented interface. (Duck adapter = new TurkeyAdapter(turkey);
            adapter.Quack();
            adapter.Fly();
        }

        static void RunHoofdstuk4()
        {
            Console.WriteLine(@"------------------------------------------------------");
            Console.WriteLine("\tPizza Store Factory Pattern Test");
            Console.WriteLine(@"------------------------------------------------------");
            PizzaStore chicagoPizzaStore = new CHPizzaStore();
            PizzaStore newYorkPizzaStore = new NYPizzaStore();
            chicagoPizzaStore.OrderPizza("Cheese");
            Console.WriteLine("........................................");
            chicagoPizzaStore.OrderPizza("Veggie");
            Console.WriteLine("........................................");
            chicagoPizzaStore.OrderPizza("Pepperoni");
            Console.WriteLine("\n-----------------------------------------\n");
            newYorkPizzaStore.OrderPizza("Cheese");
            Console.WriteLine("........................................");
            newYorkPizzaStore.OrderPizza("Veggie");
            Console.WriteLine("........................................");
            newYorkPizzaStore.OrderPizza("Pepperoni");
            Console.WriteLine(@"------------------------------------------------------");
        }

        static void RunHoofdstuk5()
        {
            MySingleton singleton = MySingleton.Instance;
            singleton.PrintText();
            Task.Run(() =>
            {
                Thread.Sleep(800);
                MySingleton singleton2 = MySingleton.Instance;
                singleton2.PrintText();
            });
            MySingleton singleton3 = MySingleton.Instance;
            singleton3.PrintText();
        }
    }
}
