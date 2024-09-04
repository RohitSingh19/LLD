using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.DesignPatterns.Observer
{
    internal class Stock : ISubject
    {
        private List<IObserver> observers;
        private string StockType;
        private decimal Price;
        public Stock(string stockType, decimal price)
        {
            observers = new List<IObserver>();
            StockType = stockType;
            Price = price;
        }

        public string StockSymbol => StockType;
        public decimal StockPrice
        { 
            get { return Price; }
            set 
            { 
                Price = value; 
                NotifyObservers();
            }
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in observers) {
                observer.Update(StockType, Price);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
    }
}
