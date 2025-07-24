namespace DesignPatternsInAction.Adapter;

public class NewPayAdapter : IPaymentGateway
{
    private readonly NewPayApiClient _newPayApi;

    public NewPayAdapter(NewPayApiClient newPayApi)
    {
        _newPayApi = newPayApi;
    }

    public bool ProcessPayment(decimal amount, string currency)
    {
        return _newPayApi.Execute(amount, currency);
    }
}
