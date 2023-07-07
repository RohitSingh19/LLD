using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.OOP
{
    public class Inheritance
    {
        public string name;
        private int age;

        public string PersonName
        {
            get { return name; }
            set { name = value; }
        }

        public int PersonAge
        {
            get { return age; }
            set { age = value; }
        }

        public Inheritance(string name)
        {
            Console.Write("Constructor called" + name);
        }
    }

    public class InheritanceExample : Inheritance
    {
        public InheritanceExample() : base("Johnty")
        {

        }
        public void Run()
        {
            InheritanceExample example = new InheritanceExample();
            example.name = "Check";
            example.PersonAge = 18;
            Console.Write(example.PersonName +" "+example.PersonAge);
            Console.ReadLine();
        }
    }
}
