namespace DesignPatternsInAction.Adapter;

public class NewPayApiClient
{
    public bool Execute(decimal value, string isoCurrencyCode)
    {
        Console.WriteLine($"[NewPayAPI] Successfully charged {value} {isoCurrencyCode} via new gateway.");
        return true;
    }
}
