using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET68_C_OOP3_Task
{
    internal abstract class PaymentMethod
    {
        protected PaymentMethod(decimal amount)
        {
            Amount = amount;
        }

        public decimal Amount { get; init; }

        public void PrintReceipt() =>
            Console.WriteLine($"\tReceipt: {GetType().Name} Paid {Amount:C}");
        
        public abstract void  Pay();
        
    }
}
