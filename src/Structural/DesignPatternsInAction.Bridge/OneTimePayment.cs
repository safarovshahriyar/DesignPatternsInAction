namespace DesignPatternsInAction.Bridge;

public class OneTimePayment : AbstractPayment
{
    public OneTimePayment(IPaymentProvider provider) : base(provider) { }

    public override void MakePayment(decimal amount)
    {
        Console.WriteLine("[One-Time Payment]");
        _provider.ProcessPayment(amount);
    }
}
