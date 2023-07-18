using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.DesignPatterns.AbstractFactory
{
    public class WindowsButton : IUIButton
    {
        public void RenderButton()
        {
            Console.WriteLine("This is a windows button");
        }
    }
}
