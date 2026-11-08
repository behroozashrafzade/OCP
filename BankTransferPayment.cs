

namespace OCP;

public class BankTransferPayment: IPaymentProcessor
{
    public void ProcessPayment(int price)
    {
        Console.WriteLine($"Process bank transfer for price : {price}");
    }

}
