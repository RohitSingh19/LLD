using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.DesignPatterns.Decorator
{
    public class CoffeeDecorator : ICoffee
    {
        public ICoffee coffeeDecorator;
        public CoffeeDecorator(ICoffee coffee)
        {
              coffeeDecorator = coffee;
        }
        public virtual double GetCost()
        {
            return coffeeDecorator.GetCost();
        }

        public virtual string GetDescription()
        {
            return coffeeDecorator.GetDescription();
        }
    }
}
