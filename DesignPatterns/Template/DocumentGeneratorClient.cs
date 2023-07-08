using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.DesignPatterns.Template
{
    public class DocumentGeneratorClient
    {
        public void RunDocumentEngine()
        {
            DocumentGenerator pdfDocument = new PdfDocumentGenerator();
            pdfDocument.GenerateDocumet();

            DocumentGenerator wordDocument = new WordDocumentGenrator();
            wordDocument.GenerateDocumet(); 
        }
    }
}
