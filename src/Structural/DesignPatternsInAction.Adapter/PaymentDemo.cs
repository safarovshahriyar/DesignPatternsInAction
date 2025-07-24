namespace DesignPatternsInAction.Adapter;

public static class PaymentDemo
{
    public static void Run()
    {
        Console.WriteLine("== Adapter Pattern: Payment Integration ==\n");

        IPaymentGateway oldGateway = new OldPaymentGateway();
        oldGateway.ProcessPayment(100, "USD");

        var newApi = new NewPayApiClient();
        IPaymentGateway adaptedGateway = new NewPayAdapter(newApi);
        adaptedGateway.ProcessPayment(150, "EUR");
    }
}
