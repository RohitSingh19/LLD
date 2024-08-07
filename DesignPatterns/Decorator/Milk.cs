using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.DesignPatterns.Decorator
{
    public class Milk : CoffeeDecorator
    {
        public Milk(ICoffee coffee):base(coffee) 
        {
        
        }

        public override double GetCost()
        {
            return base.GetCost() + 0.75;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ", milk";
        }

    }
}
