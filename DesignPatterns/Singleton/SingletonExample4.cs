using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.DesignPatterns.Singleton
{
    public sealed class SingletonExample4
    {
        private static int Counter = 0;
        private SingletonExample4()
        {
            Console.WriteLine($"Instance Counter: {++Counter}");
        }
        
        private static readonly Lazy<SingletonExample4> lazy = new Lazy<SingletonExample4>(() => new SingletonExample4());
        public static SingletonExample4 Instance
        {
            get
            {
                return lazy.Value;
            }
        }
    }
}
