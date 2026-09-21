using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class StatisticsDisplay : WeatherDisplay
    {
        private float sumTemperature = 0;
        private float maxTemp = 0;
        private float minTemp = 200; // hoge value zodat hij overschrijft bij de eerste meting
        private int countUpdated = 0;

        public StatisticsDisplay(Subject weatherData)
            : base(weatherData)
        {
        }

        protected override void UpdateData(float temp, float humidity, float pressure)
        {
            sumTemperature += temp;
            countUpdated++;

            if (temp > maxTemp)
            {
                maxTemp = temp;
            }

            if (temp < minTemp)
            {
                minTemp = temp;
            }
        }

        public override void Display()
        {
            Console.WriteLine($"Avg/Max/Min temperature = {sumTemperature / countUpdated}/{maxTemp}/{minTemp}");
        }
    }
}
