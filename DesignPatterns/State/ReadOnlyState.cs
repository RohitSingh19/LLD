using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.DesignPatterns.State
{
    public class ReadOnlyState : IDocumentState
    {
        public void Edit(Document document)
        {
            Console.WriteLine("Read Only State => Editing the document is not allowed");
        }

        public void Print(Document document)
        {
            Console.WriteLine("Read Only State => Printing the document is allowed");
        }

        public void Save(Document document)
        {
            Console.WriteLine("Read Only State => Saving the document is not allowed");
        }
    }
}
