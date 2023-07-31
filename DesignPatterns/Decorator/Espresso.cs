using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.DesignPatterns.Decorator
{
    public class Espresso : ICoffee
    {
        public double GetCost()
        {
            return 1.10;
        }

        public string GetDescription()
        {
            return "Espresso";
        }
    }
}
