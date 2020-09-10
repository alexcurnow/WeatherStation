using System;

namespace weatherStation
{
  public class CurrentConditionsDisplay : IObserver, IDisplayElement
  {
    private float _temperature;
    private float _humidity;
    private ISubject _weatherData;
    public CurrentConditionsDisplay(ISubject weatherData)
    {
      this._weatherData = weatherData;
      weatherData.registerObserver(this);
    }
    public void update(float temperature, float humidity, float pressure)
    {
      this._temperature = temperature;
      this._humidity = humidity;
      display();
    }
    public void display()
    {
      Console.WriteLine($"Current Conditions: {_temperature}F degrees and {_humidity}% humidity");
    }
  }
}