using System;
using System.Collections.Generic;
using System.Text;

namespace OCP;

public class PayPalPayment: IPaymentProcessor
{
    public void ProcessPayment(int price)
    {
        Console.WriteLine($"Process credit card payment for price :{price}");

    }

}
