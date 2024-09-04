using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LLD.DesignPatterns.Observer.Observers
{
    public class Banks : IObserver
    {
        private readonly string _name;
        public Banks(string name)
        { 
            _name = name;
        }

        public void Update(string stockType, decimal amount)
        {
            Console.WriteLine($"Notifying {_name}: Stock {stockType} is now {amount:C}");
        }
    }
}
