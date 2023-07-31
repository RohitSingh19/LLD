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
            Espresso espresso = new Espresso();

            Console.WriteLine("Espresso Coffee 1");
            Console.WriteLine($"{espresso.GetCost()} of {espresso.GetDescription()}");
            Console.WriteLine("------------------------------------------------------");

            CoffeeDecorator espressoWithMilk = new Milk(espresso);
            Console.WriteLine("Espresso Coffee 2");
            Console.WriteLine($"{espressoWithMilk.GetCost()} of {espressoWithMilk.GetDescription()}");
            Console.WriteLine("------------------------------------------------------");


            CoffeeDecorator espressoWithMilkAndSugar = new Sugar(espressoWithMilk);
            Console.WriteLine("Espresso Coffee 3");
            Console.WriteLine($"{espressoWithMilkAndSugar.GetCost().ToString("0.00")} of {espressoWithMilkAndSugar.GetDescription()}");
            Console.WriteLine("------------------------------------------------------");
        }
    }
}
