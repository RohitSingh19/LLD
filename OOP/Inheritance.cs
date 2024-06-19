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



    public class First
    { 
        public void Run()
        {
            Console.WriteLine("I am a Run function running for First");
        }
    }

    interface ISecond
    {
        public void Run();
    }

    public class Third : First, ISecond
    {
        //public void Run()
        //{
        //    Console.WriteLine("I am a Run function running for Third");
        //}

        

        public void Runner()
        { 
            Third example = new Third();
            example.Run(); //This will call Run method of first class (wrong)
            Run(); //this will call run method from third class

            First first = new First();
            first.Run(); //this will call run method for first class

            First first1 = new Third();
            first1.Run();//this will call run method for first class

        }
        
    }


    public class BaseClass
    { 
        public void functionA() { 
            
        }
        private void functionB() { }    
    }

    public class DerivedClass : BaseClass
    {
        //public B()
        //{
        //    B b = new OOP.B();
        //    b.functionA();
        //    b.functionB();
        //}

        public void test()
        { 
            DerivedClass example = new DerivedClass();
            example.functionA();
            //example.functionB();
        }
    }
}













