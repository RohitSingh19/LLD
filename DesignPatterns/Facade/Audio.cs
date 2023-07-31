using LLD.DesignPatterns.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.DesignPatterns.Facade
{
    public class Audio
    {
        public void TurnOn()
        {
            Console.WriteLine($"{typeof(Audio).Name} Turned On");
        }

        public void TurnOff()
        {
            Console.WriteLine($"{typeof(Audio).Name} Turned Off");
        }
    }
}
