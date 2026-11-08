

namespace OCP;

public class Payment
{
    public void ProcessPayment(PaymentMethod method , int perice)
    {
        switch (method)
        {
            case PaymentMethod.CreditCard:
                Console.WriteLine($"Process credit card payment for price :{perice}");
                break;
            case PaymentMethod.PayPal:
                Console.WriteLine($"Process Paypal card payment for price :{perice}");
                break;
            case PaymentMethod.BankTransfer:
                 Console.WriteLine($"Process bank transfer for price : {perice}");
                break;

            default:
                throw new ArgumentException("Unsupported payment method");

                
        }
    }

}
