using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class CurrentConditionDisplay : WeatherDisplay
    {
        private float temperature;
        private float humidity;

        public CurrentConditionDisplay(Subject weatherData)
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
            Console.WriteLine($"Current conditions: {temperature}F degrees and {humidity}% humidity");
        }
    }
}
