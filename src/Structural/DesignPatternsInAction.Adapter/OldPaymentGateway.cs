namespace DesignPatternsInAction.Adapter;

public class OldPaymentGateway : IPaymentGateway
{
    public bool ProcessPayment(decimal amount, string currency)
    {
        Console.WriteLine($"[OldPayment] Paid {amount} {currency}");
        return true;
    }
}
