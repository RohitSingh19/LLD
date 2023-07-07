using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.DesignPatterns.Builder
{
    public class TravelProductDocument : DocumentBuilder
    {
        public override void AddContent()
        {
            document.content = $"{typeof(TravelProductDocument).Name} content";
        }

        public override void AddFooter()
        {
            document.footer = $"{typeof(TravelProductDocument).Name} footer";
        }

        public override void AddHeader()
        {
            document.header = $"{typeof(TravelProductDocument).Name} header";
        }
    }
}
