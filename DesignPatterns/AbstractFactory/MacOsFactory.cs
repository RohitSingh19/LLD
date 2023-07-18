using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.DesignPatterns.AbstractFactory
{
    public class MacOsFactory : IUIFactory
    {
        public IUIButton GetButton()
        {
            return new MacOsButton();
        }

        public IUICheckBox GetCheckBox()
        {
            throw new NotImplementedException();
        }
    }
}
