using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStationCode
{
    public class StatisticsDisplay : Observer, DisplayElement 
    {
        private float temperature;
        private float humidity;
        private Subject weatherData;

        public StatisticsDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }

        public void update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            display();
        }

        public string display()
        {
            return "Statistics conditions: " + temperature + "F degrees and " + humidity + "% humidity";
        }
    }
}
