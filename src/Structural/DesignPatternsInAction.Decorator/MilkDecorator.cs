﻿namespace DesignPatternsInAction.Decorator;

public class MilkDecorator : CoffeeDecorator
{
    public MilkDecorator(ICoffee coffee) : base(coffee) { }

    public override string GetDescription() => _coffee.GetDescription() + ", Milk";

    public override double GetCost() => _coffee.GetCost() + 0.50;
}
