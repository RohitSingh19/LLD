using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.DesignPatterns.State
{
    public class Document
    {
        IDocumentState documentState;
        public Document()
        { 
            /*Starting with the readonly state*/
            documentState = new ReadOnlyState();
        }

        public void ChangeState(IDocumentState documentState)
        {
            this.documentState = documentState;
        }


        public void EditDocument()
        {
            this.documentState.Edit(this);
        }
        public void SaveDocument()
        {
            this.documentState.Save(this);
        }
        public void PrintDocument()
        {
            this.documentState.Print(this);
        }

    }
}
