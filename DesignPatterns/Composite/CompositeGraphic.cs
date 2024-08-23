using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.DesignPatterns.Composite
{
    public class CompositeGraphic : Graphic
    {
        private List<Graphic> graphics = new List<Graphic>();

        public override void Draw()
        {
            foreach(Graphic graphic in graphics)
            {
                graphic.Draw();
            }
        }

        public void Add(Graphic graphic)
        {
            graphics.Add(graphic);
        }

        public void Remove(Graphic graphic)
        {
            graphics.Remove(graphic);
        }

        public Graphic GetChild(int index)
        {
            return graphics[index];
        }
    }
}
