using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentProcessor
{
    internal class CashPayment:IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Cash payment: ${amount:F2}");
        }
    }
}
