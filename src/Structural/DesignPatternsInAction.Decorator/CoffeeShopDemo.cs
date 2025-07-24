namespace DesignPatternsInAction.Decorator;

public static class CoffeeShopDemo
{
    public static void Run()
    {
        ICoffee coffee1 = new BaseCoffee();
        Console.WriteLine($"{coffee1.GetDescription()} - ${coffee1.GetCost():0.00}");

        ICoffee coffee2 = new MilkDecorator(new SugarDecorator(new BaseCoffee()));
        Console.WriteLine($"{coffee2.GetDescription()} - ${coffee2.GetCost():0.00}");

        ICoffee coffee3 = new VanillaDecorator(new MilkDecorator(new SugarDecorator(new BaseCoffee())));
        Console.WriteLine($"{coffee3.GetDescription()} - ${coffee3.GetCost():0.00}");
    }
}
