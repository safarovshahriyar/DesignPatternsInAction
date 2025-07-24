namespace DesignPatternsInAction.Bridge;

public interface IPaymentProvider
{
    void ProcessPayment(decimal amount);
}
