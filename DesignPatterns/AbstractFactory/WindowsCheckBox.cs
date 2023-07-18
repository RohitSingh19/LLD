using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.DesignPatterns.AbstractFactory
{
    public class WindowsCheckBox : IUICheckBox
    {
        public void RenderCheckBox()
        {
            Console.WriteLine("This is windows check box");
        }
    }
}
