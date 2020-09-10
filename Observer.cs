using System;

namespace weatherStation
{
  public interface IObserver
  {
    public void update(float temp, float humidity, float pressure);
  }
}