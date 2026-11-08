
using OCP;

/*
Payment payment = new ();

payment.ProcessPayment(PaymentMethod.CreditCard, 1000_000);



[old code for run only  calss Payment]
*/



IPaymentProcessor processor = new PayPalPayment();


processor.ProcessPayment(1_000_000_000);



Console.ReadKey();