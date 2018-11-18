using System;

namespace DesignPatternsBoekOpdrachten.Week2.Hoofdstuk2
{
    class ForecastDisplay : IMeasurementChangedListener, IDisplay
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
