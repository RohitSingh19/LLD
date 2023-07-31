using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.DesignPatterns.Facade
{
    public class MultimediaPlayer
    {
        Audio audio;
        DvdPlayer dvdPlayer;
        Projector projector;
        public MultimediaPlayer()
        {
            audio = new Audio();
            dvdPlayer = new DvdPlayer();
            projector = new Projector();
        }

        public void TurnOn()
        { 
            audio.TurnOn();
            dvdPlayer.TurnOn();
            projector.TurnOn();
            Console.WriteLine();
        }

        public void TurnOff()
        {
            Console.WriteLine();
            audio.TurnOff();
            dvdPlayer.TurnOff();
            projector.TurnOff();
        }
    }
}
