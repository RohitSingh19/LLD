using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.DesignPatterns.Factory
{
    public class Rectange : IShape
    {
        public void Draw()
        {
            Console.WriteLine("A rectangle has been drawn..");
        }
    }
}
