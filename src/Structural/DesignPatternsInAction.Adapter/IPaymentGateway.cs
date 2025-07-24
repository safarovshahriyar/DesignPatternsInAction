namespace DesignPatternsInAction.Adapter;

public interface IPaymentGateway
{
    bool ProcessPayment(decimal amount, string currency);
}
