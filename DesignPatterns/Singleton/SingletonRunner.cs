using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.DesignPatterns.Singleton
{
    public class SingletonRunner
    {
        public SingletonRunner()
        {
            //SingletonExample1 example1 = SingletonExample1.Instance;
            //SingletonExample1 example2 = SingletonExample1.Instance;


            /*These statement access the Instance Parallely and it execute Parallel loops and creates concurrency*/
            const int threadCount = 5;
            //Parallel.For(0, threadCount, i =>
            //{
            //    SingletonExample1 example = SingletonExample1.Instance;
            //});




            Parallel.For(0, threadCount, i =>
            {
                SingletonExample4 example = SingletonExample4.Instance;
            });

            Console.WriteLine();
        }
    }
}



