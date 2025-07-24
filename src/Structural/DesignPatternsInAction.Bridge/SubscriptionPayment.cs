namespace DesignPatternsInAction.Bridge;

public class SubscriptionPayment : AbstractPayment
{
    public SubscriptionPayment(IPaymentProvider provider) : base(provider) { }

    public override void MakePayment(decimal amount)
    {
        Console.WriteLine("[Subscription Payment - Monthly]");
        _provider.ProcessPayment(amount);
    }
}
