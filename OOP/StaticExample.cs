using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.OOP
{
    public static class StaticExample
    {
        public static string name;
        public static string description;
        //public StaticExample() 
        //{
        //    name = "Rohit";
        //    description = "Description from cons";
        //    Console.WriteLine("Public default constructor executed " + name);
        //}

        static StaticExample()
        {
            description = "description from static constructor";
        }

        //public void Foo()
        //{
        //    throw new NotImplementedException();
        //}
    }

    public class exa 
    {

    }

    public interface IFoo {
        public void Foo();
    }
}
