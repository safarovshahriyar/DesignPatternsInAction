namespace DesignPatternsInAction.Bridge;

public static class BridgeDemo
{
    public static void Run()
    {
        Console.WriteLine("== Bridge Pattern: Payment Gateways ==\n");

        IPaymentProvider stripe = new StripeProvider();
        IPaymentProvider paypal = new PayPalProvider();

        AbstractPayment oneTimeStripe = new OneTimePayment(stripe);
        oneTimeStripe.MakePayment(99.99m);

        AbstractPayment subPaypal = new SubscriptionPayment(paypal);
        subPaypal.MakePayment(19.99m);
    }
}
