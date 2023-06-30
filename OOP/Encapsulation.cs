using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.OOP
{
    public class Encapsulation
    {
        private string name;
        private int age;

        public string Name
        { 
            get { return name;}
            set { name = value;}
        }

        public int Age
        { 
            get { return age; }
            set { age = value; }
        }
    }

    public class EncapsulationExample
    {
        public void Run()
        {
            Encapsulation example = new Encapsulation();
            example.Name = "Garry Sobers";
            example.Age = 18;
            Console.WriteLine("My Name is "+example.Name + " and I am "+example.Age+" years old");
        }
    }
}
