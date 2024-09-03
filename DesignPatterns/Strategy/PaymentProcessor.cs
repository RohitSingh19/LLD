using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.DesignPatterns.Strategy
{
    public class PaymentProcessor
    {
        private IPaymnetMethod paymnetMethod;

        public void SetPaymentMethod(IPaymnetMethod paymnetMethod)
        { 
            this.paymnetMethod = paymnetMethod;
        }

        public void ProcessPayment(decimal amount) 
        {
            this.paymnetMethod.MakePayment(amount);
        }

    }
}
