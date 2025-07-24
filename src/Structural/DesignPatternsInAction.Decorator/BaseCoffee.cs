namespace DesignPatternsInAction.Decorator;

public class BaseCoffee : ICoffee
{
    public string GetDescription() => "Plain Coffee";

    public double GetCost() => 2.00;
}
