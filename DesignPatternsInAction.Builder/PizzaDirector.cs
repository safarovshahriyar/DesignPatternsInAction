namespace DesignPatternsInAction.Builder;

public class PizzaDirector
{
    public void ConstructPizza(IPizzaBuilder builder)
    {
        builder.Reset();
        builder.AddDough();
        builder.AddSauce();
        builder.AddCheese();
        builder.AddToppings();
    }
}
