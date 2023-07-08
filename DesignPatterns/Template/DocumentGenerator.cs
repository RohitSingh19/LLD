using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.DesignPatterns.Template
{
    public abstract class DocumentGenerator
    {

        public void GenerateDocumet()
        {
            AddHeader();
            AddContent();
            AddFooter();
        }
        protected void AddHeader()
        {
            Console.WriteLine("===== HEADER ======");
        }

        protected abstract void AddContent();

        protected void AddFooter()
        {
            Console.WriteLine("===== FOOTER ======");
        }
    }
}
