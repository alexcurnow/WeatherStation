using System;

namespace weatherStation
{
  public interface ISubject
  {
    public void registerObserver(IObserver observer);
    public void removeObserver(IObserver observer);
    public void notifyObservers();
  }
}