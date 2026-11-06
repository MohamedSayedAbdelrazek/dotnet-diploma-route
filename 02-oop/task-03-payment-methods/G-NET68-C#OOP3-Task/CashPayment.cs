using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET68_C_OOP3_Task
{
    internal class CashPayment : PaymentMethod
    {
        public CashPayment(decimal amount) : base(amount)
        {

        }

        public override void Pay()
        {
            Console.WriteLine($"Paying {Amount} in Cash");
        }
    }
}
