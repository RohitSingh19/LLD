using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.DesignPatterns.Template
{
    public class WordDocumentGenrator : DocumentGenerator
    {
        protected override void AddContent()
        {
            Console.WriteLine("Content for Word File..");
        }
    }
}
