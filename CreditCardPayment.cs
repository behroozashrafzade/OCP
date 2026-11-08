

namespace OCP;

public class CreditCardPayment:IPaymentProcessor
{

    public void ProcessPayment(int price)
    {
        Console.WriteLine( $"Process Paypal card payment for price :{price}");
    }


}
