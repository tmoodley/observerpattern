﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStationCode
{
    public class ForecastDisplay : Observer, DisplayElement 
    {
        private float temperature;
        private float humidity;
        private Subject weatherData;

        public ForecastDisplay(Subject weatherData)
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
            return "Forecast conditions: " + temperature + "F degrees and " + humidity + "% humidity";
        }
    }
}
