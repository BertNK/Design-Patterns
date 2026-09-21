using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class ForecastDisplay : WeatherDisplay
    {
        private float temperature;
        private float humidity;

        public ForecastDisplay(Subject weatherData)
            : base(weatherData)
        {
        }

        protected override void UpdateData(float temp, float humidity, float pressure)
        {
            temperature = temp;
            this.humidity = humidity;
        }

        public override void Display()
        {
            if (temperature > 80 && humidity < 40)
            {
                Console.WriteLine("Forecast: Its going to be hot and dry today.");
            }
            else if (temperature > 80 && humidity > 50)
            {
                Console.WriteLine("Forecast: Its going to be warm and humid today.");
            }
            else if (temperature < 50 && humidity > 70)
            {
                Console.WriteLine("Forecast: Its going to be cold and wet today.");
            }
            else
            {
                Console.WriteLine("Forecast: The weather is expected to be mild today.");
            }

        }
    }
}
