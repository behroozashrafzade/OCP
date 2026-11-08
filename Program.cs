
using OCP;


Payment payment = new ();

payment.ProcessPayment(PaymentMethod.CreditCard, 1000_0000);


Console.ReadKey();