using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.DesignPatterns.Strategy
{
    internal class COD : IPaymnetMethod
    {
        public void MakePayment(decimal amount)
        {
            Console.WriteLine($"Making payment of ${amount} using ${typeof(COD)}");
        }
    }
}
