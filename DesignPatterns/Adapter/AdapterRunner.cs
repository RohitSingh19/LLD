using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.DesignPatterns.Adapter
{
    public class AdapterRunner
    {
        public AdapterRunner()
        {
            LegacyPrinter legacyPrinter = new LegacyPrinter();
            IPrinter printer = new PrinterAdapter(legacyPrinter);

            Client client = new Client();
            client.PrintDocument(printer, "This is text docment");

            Console.ReadKey();
        }
    }
}
