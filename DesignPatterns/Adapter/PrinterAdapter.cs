using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.DesignPatterns.Adapter
{
    public class PrinterAdapter : IPrinter
    {
        LegacyPrinter legacyPrinter = new LegacyPrinter();
        public PrinterAdapter(LegacyPrinter legacyPrinter)
        {
             this.legacyPrinter = legacyPrinter;
        }

        public void Print(string text)
        {
            this.legacyPrinter.Print(text);
        }
    }
}
