using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentProcessor
{
    internal class CreditCardPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Credit card payment: ${amount:F2}");
        }
    }
}
