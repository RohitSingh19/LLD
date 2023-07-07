using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.OOP
{
   
    public class A
    {
        public void Method()
        {
            Console.Write("Method From A called");
        }
    }

    public interface B
    {
        public void Method();
    }

    public class inhertiance : B
    {
        public void Function()
        {
            inhertiance c = new inhertiance();
            c.Method();
            
        }

        public void Method()
        {
            Console.WriteLine("This");
        }
    }
}
