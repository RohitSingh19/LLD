using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LLD.OOP
{
    public class AssociationExample
    {
        public void RunAssociationExample()
        { 
            Engine engine = new Engine();
            Car car = new Car(engine);
            car.start();
        }
    }

    public class Car
    {
        private Engine _engine;
        public Car(Engine engine)
        {
            _engine = engine;
        }

        public void start()
        { 
            _engine.start();
        }
    }

    public class Engine
    {
        public void start()
        {
            Console.WriteLine("Engine Started...");
        }
    }


}
//https://stackoverflow.com/a/68011774/13218645 