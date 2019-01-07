using DesignPatternsBoekOpdrachten.Week_1;
using DesignPatternsBoekOpdrachten.Week_3.Hoofdstuk_4.PizzaStore;
using DesignPatternsBoekOpdrachten.Week_3.Hoofdstuk_5;
using DesignPatternsBoekOpdrachten.Week_4.Hoofdstuk_10;
using DesignPatternsBoekOpdrachten.Week_4.Hoofdstuk_6;
using DesignPatternsBoekOpdrachten.Week_5_en_6.BuilderPattern;
using DesignPatternsBoekOpdrachten.Week2.Hoofdstuk_2;
using DesignPatternsBoekOpdrachten.Week2.Hoofdstuk_3;
using DesignPatternsBoekOpdrachten.Week2.Hoofdstuk_7;
using System;
using System.Threading;
using System.Threading.Tasks;
using Duck = DesignPatternsBoekOpdrachten.Week_1.Duck;

namespace DesignPatternsBoekOpdrachten
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            //RunStrategyPattern();
            //RunObserverPattern();
            //RunDecoratorPattern();
            //RunFactoryPattern();
            //RunSingletonPattern();
            //RunCommandPattern();
            //RunAdapterPattern();
            //RunStatePattern();
            RunBuilderPattern();
            Console.ReadKey();
        }

        private static void RunStrategyPattern()
        {
            Duck model = new ModelDuck();
            model.PerformFly();
            model.PerformQuack();
            model.SetFlyBehavior(new FlyRocketPowered());
            model.PerformFly();
        }

        private static void RunObserverPattern()
        {
            var data = new WeatherData();
            new CurrentConditionsDisplay(data);
            new StatisticsDisplay(data);
            new ForecastDisplay(data);
            data.Temperature = 22.7;
        }

        private static void RunDecoratorPattern()
        {
            Beverage beverage = new Espresso();
            Console.WriteLine($"{beverage.GetDescription()} ${beverage.Cost()}");
            Beverage beverage1 = new HouseBlend();
            beverage1 = new Mocha(beverage1);
            beverage1 = new Mocha(beverage1);
            beverage1 = new Whip(beverage1);
            Console.WriteLine($"{beverage1.GetDescription()} ${beverage1.Cost()}");
        }

        private static void RunAdapterPattern()
        {
            var duck = new Week2.Hoofdstuk_7.Duck();
            var turkey = new Turkey();
            var adapter =
                new TurkeyAdapter(
                    turkey); //Should be of type Duck if duck was the implemented interface. (Duck adapter = new TurkeyAdapter(turkey);
            adapter.Quack();
            adapter.Fly();
        }

        private static void RunFactoryPattern()
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

        private static void RunSingletonPattern()
        {
            var singleton = MySingleton.Instance;
            singleton.PrintText();
            Task.Run(() =>
            {
                Thread.Sleep(800);
                var singleton2 = MySingleton.Instance;
                singleton2.PrintText();
            });
            var singleton3 = MySingleton.Instance;
            singleton3.PrintText();
        }

        private static void RunCommandPattern()
        {
            var test = new RemoteControlTest();
        }

        private static void RunStatePattern()
        {
            new GumballMachineTest();
        }

        private static void RunBuilderPattern()
        {
            new PlaneBuilderTest();
        }
    }
}