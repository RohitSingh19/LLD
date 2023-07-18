using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.DesignPatterns.AbstractFactory
{
    public class WindowsFactory : IUIFactory
    {
        public IUIButton GetButton()
        {
            return new WindowsButton();
        }

        public IUICheckBox GetCheckBox()
        {
            return new WindowsCheckBox();
        }
    }
}
