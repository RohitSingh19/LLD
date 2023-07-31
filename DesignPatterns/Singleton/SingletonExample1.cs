using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LLD.DesignPatterns.Singleton
{

    /*
         This singleton design pattern example is not thread safe.
    */
    public sealed class SingletonExample1
    {
        private static int Counter = 0;
        private SingletonExample1()
        {
            Console.WriteLine($"Instance Counter: {++Counter}");
        }
        private static SingletonExample1 obj = null;

        public static SingletonExample1 Instance
        {
            get
            {
                if (obj == null) return obj = new SingletonExample1();
                else return obj;
            }
        }
    }
}
