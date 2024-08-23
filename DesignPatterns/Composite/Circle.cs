using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.DesignPatterns.Composite
{
    public class Circle : Graphic
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing Circle..");
        }
    }
}
