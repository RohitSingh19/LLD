using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.DesignPatterns.Decorator
{
    public class Decaf : ICoffee
    {
        public double GetCost()
        {
            return 1.20;
        }

        public string GetDescription()
        {
            return "Decaf";
        }
    }
}
