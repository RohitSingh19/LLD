using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.DesignPatterns.State
{
    public class StateRunner
    {
        public StateRunner()
        {
            Document document = new Document();
            document.PrintDocument();
            document.EditDocument();
            document.SaveDocument();

            document.ChangeState(new ReadWriteState());
            document.PrintDocument();
            document.EditDocument();
            document.SaveDocument();

        }
    }
}
