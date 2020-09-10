using System;

namespace weatherStation
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);

            weatherData.setMeasurements(78, 90, 29.2f);
            weatherData.measurementsChanged();
        }
    }
}