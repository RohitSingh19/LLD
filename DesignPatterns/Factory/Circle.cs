using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.DesignPatterns.Factory
{
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("A cricle has been drawn..");
        }
    }
}
