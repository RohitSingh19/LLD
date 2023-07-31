using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.DesignPatterns.Singleton
{
    /*
         This singleton design pattern example is thread safe and double check locking.

        The double-checked locking is a technique used in multithreaded environments to improve the performance of creating 
        a singleton instance while ensuring thread safety. In a multithreaded scenario, multiple threads may attempt
        to access the singleton instance simultaneously, which could lead to the creation of multiple instances if not handled correctly.
        The double-checked locking helps to prevent unnecessary locking and improve performance in certain situations.

        The double-checked locking optimizes the singleton creation process by minimizing the locking overhead when the instance is 
        already created. It improves performance in cases where the instance is often accessed and the instance creation is an expensive 
        operation.
    */
    public sealed class SingletonExample3
    {
        private static readonly object obj = new Object();
        private static int Counter = 0;
        private SingletonExample3()
        {
            Console.WriteLine($"Instance Counter: {++Counter}");
        }
        private static SingletonExample3 instance = null;

        public static SingletonExample3 Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (obj)
                    {
                        if (instance == null)
                        {
                            return instance = new SingletonExample3();
                        }

                    }
                }
                return instance;
            }
        }
    }
}
