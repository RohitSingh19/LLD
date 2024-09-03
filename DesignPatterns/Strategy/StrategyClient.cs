using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.DesignPatterns.Strategy
{
    public class StrategyClient
    {
        public StrategyClient(string paymentMethod, decimal amount) 
        {
            PaymentProcessor paymentProcessor = new PaymentProcessor();

            if (paymentMethod == "UPI")
            {
                UPI uPI = new UPI();
                paymentProcessor.SetPaymentMethod(uPI);
                paymentProcessor.ProcessPayment(amount);
            }

            else if (paymentMethod == "NEFT")
            {
                NEFT neft = new NEFT();
                paymentProcessor.SetPaymentMethod(neft);
                paymentProcessor.ProcessPayment(amount);
            }
            else {
                throw new Exception("Unkown payment method");
            }
        }
    }
}
