using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.DesignPatterns.Composite
{
    public class CompositeRunner
    {
        public CompositeRunner()
        {
            Graphic g1 = new Circle();
            Graphic g2 = new Square();
            Graphic g3 = new Circle();

            CompositeGraphic compositeGraphic = new CompositeGraphic();
            compositeGraphic.Add(g1);
            compositeGraphic.Add(g2);
            compositeGraphic.Add(g3);

            compositeGraphic.Draw();

            Console.WriteLine("Removing g2");
            compositeGraphic.Remove(g2);

            compositeGraphic.Draw();

            Console.WriteLine("Printing first child");
            compositeGraphic.GetChild(0).Draw();
        }
    }
}
