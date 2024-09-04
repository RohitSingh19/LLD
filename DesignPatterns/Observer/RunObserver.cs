using LLD.DesignPatterns.Observer.Observers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.DesignPatterns.Observer
{
    public class RunObserver
    {
        public RunObserver() 
        {
            Stock appleStock = new Stock("AAPL", 150.00m);
            IObserver investor1 = new Investors("John Doe");
            IObserver investor2 = new Investors("Jane Smith");

            IObserver bank = new Banks("Bandhan Bank");

            appleStock.RegisterObserver(investor1);
            appleStock.RegisterObserver(investor2);
            appleStock.RegisterObserver(bank);

            appleStock.StockPrice = 100;
            appleStock.StockPrice = 150;

            appleStock.RemoveObserver(investor1);

            appleStock.StockPrice = 250;
        }
    }
}
