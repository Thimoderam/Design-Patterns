using System.Collections.Generic;

namespace DesignPatternsBoekOpdrachten.Week2.Hoofdstuk_2
{
    public class WeatherData
    {
        private readonly List<IMeasurementChangedListener> listeners;
        private double barometricPressure;
        private double humidity;
        private double temperature;

        public WeatherData()
        {
            listeners = new List<IMeasurementChangedListener>();
        }

        public double Temperature
        {
            get => 22.5;
            set
            {
                temperature = value;
                MeasurementChanged();
            }
        }

        public double Humidity
        {
            get => 70.5;
            set
            {
                humidity = value;
                MeasurementChanged();
            }
        }

        public double BarometricPressure
        {
            get => 20.3;
            set
            {
                barometricPressure = value;
                MeasurementChanged();
            }
        }

        private void MeasurementChanged()
        {
            foreach (var listener in listeners) listener.OnMeasurementChanged(this);
        }

        public void AddListener(IMeasurementChangedListener listener)
        {
            listeners.Add(listener);
        }

        public void RemoveListener(IMeasurementChangedListener listener)
        {
            listeners.RemoveAt(listeners.IndexOf(listener));
        }
    }
}