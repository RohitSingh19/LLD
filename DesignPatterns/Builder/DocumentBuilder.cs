using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.DesignPatterns.Builder
{
    public abstract class DocumentBuilder
    {
        protected Document document;

        public Document GetDocument()
        {
            return document;
        }

        public void CreateDocument()
        { 
            document = new Document();
        }

        public abstract void AddHeader();
        public abstract void AddContent();
        public abstract void AddFooter();
    }
}
