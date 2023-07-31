using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.DesignPatterns.Facade
{
    public class FacadeRunner
    {
        public FacadeRunner()
        {
            MultimediaPlayer multimediaPlayer = new MultimediaPlayer();
            multimediaPlayer.TurnOn();

            Thread.Sleep(5000);

            multimediaPlayer.TurnOff();
        }
    }
}
