using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.DesignPatterns.Decorator
{
    public class Sugar : CoffeeDecorator
    {
        public Sugar(ICoffee coffee): base(coffee)
        {
        }

        public override double GetCost()
        {
            return base.GetCost() + .10;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + " ,sugar";
        }
    }
}
