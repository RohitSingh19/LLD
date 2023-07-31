using LLD.DesignPatterns.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.DesignPatterns.Facade
{
    public class DvdPlayer
    {
       public void TurnOn()
       {
            Console.WriteLine($"{typeof(DvdPlayer).Name} Turned On");
       }

       public void TurnOff()
       {
            Console.WriteLine($"{typeof(DvdPlayer).Name} Turned Off");
       }
    }
}
