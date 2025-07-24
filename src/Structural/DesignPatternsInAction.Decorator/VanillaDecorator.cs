namespace DesignPatternsInAction.Decorator;

public class VanillaDecorator : CoffeeDecorator
{
    public VanillaDecorator(ICoffee coffee) : base(coffee) { }

    public override string GetDescription() => _coffee.GetDescription() + ", Vanilla";

    public override double GetCost() => _coffee.GetCost() + 0.75;
}
