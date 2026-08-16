using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET68_C_OOP3_Task
{
    internal class CreditCardPayment : PaymentMethod, IRefundable
    {
        public CreditCardPayment(decimal amount) : base(amount)
        {
        }

        public override void Pay()
        {
            Console.WriteLine($"Paying {Amount} With Credit Card");
        }

        public void Refund()
        {
            Console.WriteLine($"Refunding {Amount} To Credit Card");
        }
    }
}
