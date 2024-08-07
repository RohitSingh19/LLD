using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.DesignPatterns.Decorator
{
    public class DecoratorRunner
    {
        public DecoratorRunner()
        {
            
            ICoffee coffee = new DecafCoffee();
            Console.WriteLine("Cost: " + coffee.GetCost() + " Description: " + coffee.GetDescription());    

            ICoffee coffee1 = new EspressoCoffee();
            Console.WriteLine("Cost: " + coffee1.GetCost() + " Description: " + coffee1.GetDescription());

            coffee = new Sugar(coffee);
            Console.WriteLine("Cost: " + coffee.GetCost() + " Description: " + coffee.GetDescription());

            coffee1 = new Milk(coffee1);
            Console.WriteLine("Cost: " + coffee1.GetCost() + " Description: " + coffee1.GetDescription());

            ICoffee coffee2 = new Sugar(new Milk( new EspressoCoffee())); 
            Console.WriteLine("Cost: " + coffee2.GetCost() + " Description: " + coffee2.GetDescription());
        }
    }
}
