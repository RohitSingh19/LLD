using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.DesignPatterns.Strategy
{
    public interface IPaymnetMethod
    {
        void MakePayment(decimal amount);
    }
}
