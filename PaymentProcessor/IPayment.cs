using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentProcessor
{
    public interface IPayment
    {
        void Pay(decimal amount);
    }
}
