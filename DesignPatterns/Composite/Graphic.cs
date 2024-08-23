using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.DesignPatterns.Composite
{
    public abstract class Graphic
    {
        public abstract void Draw();

        public void Add(Graphic graphic)
        {
            throw new NotImplementedException();
        }

        public void Remove(Graphic graphic)
        {
            throw new NotImplementedException();
        }   

        public Graphic GetChild(int index)
        {
            throw new NotImplementedException();
        }
    }
}
