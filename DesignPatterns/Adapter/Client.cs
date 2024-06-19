using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.DesignPatterns.Adapter
{
    public class Client
    {
        public void PrintDocument(IPrinter printer, string text)
        {
            printer.Print(text);
        }
    }
}
