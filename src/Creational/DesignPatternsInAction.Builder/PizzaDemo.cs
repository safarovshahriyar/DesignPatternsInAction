namespace DesignPatternsInAction.Builder;

public static class PizzaDemo
{
    public static void Run()
    {
        var director = new PizzaDirector();

        var margheritaBuilder = new MargheritaPizzaBuilder();
        director.ConstructPizza(margheritaBuilder);
        var margherita = margheritaBuilder.Build();
        Console.WriteLine("== Margherita Pizza ==");
        Console.WriteLine(margherita.Describe());

        var meatBuilder = new MeatLoversPizzaBuilder();
        director.ConstructPizza(meatBuilder);
        var meatPizza = meatBuilder.Build();
        Console.WriteLine("== Meat Lovers Pizza ==");
        Console.WriteLine(meatPizza.Describe());
    }
}
