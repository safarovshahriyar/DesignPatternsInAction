namespace DesignPatternsInAction.Bridge;

public abstract class AbstractPayment
{
    protected readonly IPaymentProvider _provider;

    protected AbstractPayment(IPaymentProvider provider)
    {
        _provider = provider;
    }

    public abstract void MakePayment(decimal amount);
}
