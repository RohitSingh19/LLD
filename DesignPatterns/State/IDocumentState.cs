using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.DesignPatterns.State
{
    public interface IDocumentState
    {
        void Edit(Document document);
        void Save(Document document);
        void Print(Document document);
    }
}
