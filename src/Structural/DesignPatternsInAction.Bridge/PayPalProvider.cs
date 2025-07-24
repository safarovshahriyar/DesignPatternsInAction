namespace DesignPatternsInAction.Bridge;

public class PayPalProvider : IPaymentProvider
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"[PayPal] Charged {amount:C} via PayPal");
    }
}
