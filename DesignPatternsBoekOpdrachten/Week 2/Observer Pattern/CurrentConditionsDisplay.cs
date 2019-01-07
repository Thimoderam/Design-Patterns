using System;

namespace DesignPatternsBoekOpdrachten.Week2.Hoofdstuk_2
{
    internal class CurrentConditionsDisplay : IMeasurementChangedListener, IDisplay
    {
        public CurrentConditionsDisplay(WeatherData data)
        {
            data.AddListener(this);
        }

        public void Display()
        {
            Console.WriteLine("Current conditions displaying!");
        }

        public void OnMeasurementChanged(WeatherData data)
        {
            Display();
        }
    }
}