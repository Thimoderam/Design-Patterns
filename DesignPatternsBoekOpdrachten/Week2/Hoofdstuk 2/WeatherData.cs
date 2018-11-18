using System.Collections.Generic;

namespace DesignPatternsBoekOpdrachten.Week2.Hoofdstuk2
{
    class WeatherData
    {
        private double temperature;
        private double humidity;
        private double barometricPressure;
        private List<IMeasurementChangedListener> listeners;
        public WeatherData()
        {
            listeners = new List<IMeasurementChangedListener>();
        }
        public double Temperature { get { return 22.5; } set { temperature = value; MeasurementChanged(); } }
        public double Humidity { get { return 70.5; } set { humidity = value; MeasurementChanged(); } }
        public double BarometricPressure { get { return 20.3; } set { barometricPressure = value; MeasurementChanged(); } }
        public void MeasurementChanged()
        {
            foreach (IMeasurementChangedListener listener in listeners)
            {
                listener.OnMeasurementChanged(this);
            }
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
