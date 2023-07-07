using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.DesignPatterns.Builder
{
    public class HomeProductDocument : DocumentBuilder
    {
        public override void AddContent()
        {
            document.content = $"{typeof(HomeProductDocument).Name} content";
        }

        public override void AddFooter()
        {
            document.footer = $"{typeof(HomeProductDocument).Name} footer";
        }

        public override void AddHeader()
        {
            document.header = $"{typeof(HomeProductDocument).Name} header";
        }
    }
}
