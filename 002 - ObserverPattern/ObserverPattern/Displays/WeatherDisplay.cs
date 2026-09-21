using ObserverPattern.Interfaces;

namespace ObserverPattern.Displays
{
    internal abstract class WeatherDisplay : Observer, DisplayElement
    {
        protected WeatherDisplay(Subject weatherData)
        {
            weatherData.RegisterObserver(this);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            UpdateData(temp, humidity, pressure);
            Display();
        }

        protected abstract void UpdateData(float temp, float humidity, float pressure);

        public abstract void Display();
    }
}
