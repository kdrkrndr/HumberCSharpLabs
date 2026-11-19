using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentProcessor
{
    internal class PayPalPayment:IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Pay Pal payment: ${amount:F2}");
        }
    }
}
