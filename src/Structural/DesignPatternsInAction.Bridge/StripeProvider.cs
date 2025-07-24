namespace DesignPatternsInAction.Bridge;

public class StripeProvider : IPaymentProvider
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"[Stripe] Processed payment of {amount:C}");
    }
}
