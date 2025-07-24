namespace DesignPatternsInAction.Builder;

public class MargheritaPizzaBuilder : IPizzaBuilder
{
    private Pizza _pizza = new();

    public void Reset() => _pizza = new();

    public void AddDough() => _pizza.AddIngredient("Thin crust dough");

    public void AddSauce() => _pizza.AddIngredient("Tomato sauce");

    public void AddCheese() => _pizza.AddIngredient("Mozzarella cheese");

    public void AddToppings() => _pizza.AddIngredient("Fresh basil");

    public Pizza Build()
    {
        var result = _pizza;
        Reset();
        return result;
    }
}
