namespace DesignPatternsInAction.Builder;

public class MeatLoversPizzaBuilder : IPizzaBuilder
{
    private Pizza _pizza = new();

    public void Reset() => _pizza = new();

    public void AddDough() => _pizza.AddIngredient("Thick crust dough");

    public void AddSauce() => _pizza.AddIngredient("Barbecue sauce");

    public void AddCheese() => _pizza.AddIngredient("Cheddar cheese");

    public void AddToppings()
    {
        _pizza.AddIngredient("Pepperoni");
        _pizza.AddIngredient("Bacon");
        _pizza.AddIngredient("Sausage");
    }

    public Pizza Build()
    {
        var result = _pizza;
        Reset();
        return result;
    }
}
