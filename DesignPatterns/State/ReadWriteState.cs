using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.DesignPatterns.State
{
    public class ReadWriteState : IDocumentState
    {
        public void Edit(Document document)
        {
            Console.WriteLine("Read Write State => Editing the document is allowed");
        }

        public void Print(Document document)
        {
            Console.WriteLine("Read Write State => Printing the document is allowed");
        }

        public void Save(Document document)
        {
            Console.WriteLine("Read Write State => Saving the document is allowed");
        }
    }
}
