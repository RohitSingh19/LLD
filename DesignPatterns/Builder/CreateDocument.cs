using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.DesignPatterns.Builder
{
    public class CreateDocument
    {
        private readonly DocumentBuilder _builder;
        public CreateDocument(DocumentBuilder builder)
        {
            _builder = builder; 
        }

        public void CreateNewDocument()
        { 
            _builder.CreateDocument();
            _builder.AddHeader();
            _builder.AddContent();  
            _builder.AddFooter();
        }

    }
}
