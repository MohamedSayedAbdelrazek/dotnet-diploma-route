namespace G_NET68_C_OOP3_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PaymentMethod[] payments = {
                new CreditCardPayment(1500),
                new CashPayment(1500)
            };

            foreach (PaymentMethod pay in payments) {
                pay.Pay();
                pay.PrintReceipt();
                if(pay is IRefundable p)
                    p.Refund();
                Console.WriteLine("____________________________________________________");
            }

        }
    }
}
