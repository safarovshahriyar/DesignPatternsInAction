﻿namespace DesignPatternsInAction.Decorator
{
    public class SugarDecorator : CoffeeDecorator
    {
        public SugarDecorator(ICoffee coffee) : base(coffee) { }

        public override string GetDescription() => _coffee.GetDescription() + ", Sugar";

        public override double GetCost() => _coffee.GetCost() + 0.20;
    }
}
