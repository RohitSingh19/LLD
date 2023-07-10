using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.DesignPatterns.Factory
{
    public class ShapeFactory
    {
        public IShape GetShape(string type)
        {
            switch (type)
            {
                case "circle":
                    return new Circle();
                case "rectangle":
                    return new Rectange();
                default:
                    throw new ArgumentException("Given shape is not available");
            }
        }
    }
}
