using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.DesignPatterns.Singleton
{
    /*
          This singleton design pattern example is thread safe with the help to lock 
            that allows only a single thread can create an object.
     */
    public sealed class SingletonExample2
    {
        private static readonly object obj = new Object();
        private static int Counter = 0;
        private SingletonExample2()
        {
            Console.WriteLine($"Instance Counter: {++Counter}");
        }
        private static SingletonExample2 instance = null;

        public static SingletonExample2 Instance
        {
            get
            {
                lock (obj)
                {
                    if (instance == null) {
                        return instance = new SingletonExample2();
                    }
                    
                }
               return instance;
            }
        }
    }
}
