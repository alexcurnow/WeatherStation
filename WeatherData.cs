using System;
using System.Collections;

namespace weatherStation
{
  public class WeatherData : ISubject
  {
    private ArrayList _observers;
    private float _temperature;
    private float _humidity;
    private float _pressure;
    public WeatherData()
    {
      _observers = new ArrayList();
    }
    public void registerObserver(IObserver observer)
    {
      _observers.Add(observer);
    }
    public void removeObserver(IObserver observer)
    {
      int i = _observers.IndexOf(observer);
      if (i >= 0)
      {
        _observers.Remove(i);
      }
    }
    public void notifyObservers()
    {
      foreach (IObserver observer in _observers)
      {
        observer.update(_temperature, _humidity, _pressure);
      }
    }
    public void measurementsChanged()
    {
      notifyObservers();
    }

    public void setMeasurements(float temperature, float humidity, float pressure)
    {
      this._temperature = temperature;
      this._humidity = humidity;
      this._pressure = pressure;
    }
  }
}