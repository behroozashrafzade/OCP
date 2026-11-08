
using OCP;


Payment payment = new ();

payment.ProcessPayment(PaymentMethod.CreditCard, 1000_000);


Console.ReadKey();