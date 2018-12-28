using System;

namespace DesignPatternsBoekOpdrachten.Week2.Hoofdstuk_2
{
    internal class ForecastDisplay : IMeasurementChangedListener, IDisplay
    {
        public ForecastDisplay(WeatherData data)
        {
            data.AddListener(this);
        }

        public void Display()
        {
            Console.WriteLine("Forecast displaying!");
        }

        public void OnMeasurementChanged(WeatherData data)
        {
            Display();
        }
    }
}