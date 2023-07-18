﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.DesignPatterns.AbstractFactory
{
    public interface IUIFactory
    {
        IUIButton GetButton();
        IUICheckBox GetCheckBox();
    }
}
