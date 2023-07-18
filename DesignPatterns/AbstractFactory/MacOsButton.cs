using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.DesignPatterns.AbstractFactory
{
    public class MacOsButton : IUIButton
    {
        public void RenderButton()
        {
            Console.WriteLine("This is macOs button");
        }
    }
}
