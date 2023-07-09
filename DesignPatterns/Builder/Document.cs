using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.DesignPatterns.Builder
{
    public class Document
    {
        public string header { get; set; }
        public string footer { get; set; }
        public string content { get; set; }

        public void printDocument()
        {
            Console.WriteLine($"This is a document [START]");
            Console.WriteLine($"HEADER  => {header}");
            Console.WriteLine($"CONTENT => {content}");
            Console.WriteLine($"FOOTER => {footer}");
            Console.WriteLine($"This is a document [END]");
            Console.WriteLine();
        }
    }
}
