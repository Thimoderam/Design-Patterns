using System;

namespace DesignPatternsBoekOpdrachten.Week2.Hoofdstuk_2
{
    internal class StatisticsDisplay : IMeasurementChangedListener, IDisplay
    {
        public StatisticsDisplay(WeatherData data)
        {
            data.AddListener(this);
        }

        public void Display()
        {
            Console.WriteLine("Statistics displaying!");
        }

        public void OnMeasurementChanged(WeatherData data)
        {
            Display();
        }
    }
}