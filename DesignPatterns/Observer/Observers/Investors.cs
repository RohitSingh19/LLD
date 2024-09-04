using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.DesignPatterns.Observer.Observers
{
    public class Investors : IObserver
    {
        private readonly string _name;
        public Investors(string name)
        {
            _name = name;
        }

        public void Update(string stockType, decimal amount)
        {
            Console.WriteLine($"Notifying {_name}: Stock {stockType} is now {amount:C}");
        }
    }
}
