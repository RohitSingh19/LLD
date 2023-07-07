using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.DesignPatterns.Builder
{
    public class DocumentEngine
    {
        public void RunDocumentEngine()
        {
            DocumentBuilder builder;
            
            builder = new HomeProductDocument();

            CreateDocument createHomeDocument = new CreateDocument(builder);
            createHomeDocument.CreateNewDocument();

            Document home = builder.GetDocument();
            home.printDocument();

            builder = new TravelProductDocument();

            CreateDocument createTravelDocument = new CreateDocument(builder);
            createTravelDocument.CreateNewDocument();

            Document travel = builder.GetDocument();
            travel.printDocument();

        }
    }
}
