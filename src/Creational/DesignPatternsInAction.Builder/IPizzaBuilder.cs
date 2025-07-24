namespace DesignPatternsInAction.Builder;

public interface IPizzaBuilder
{
    void Reset();
    void AddDough();
    void AddSauce();
    void AddCheese();
    void AddToppings();
    Pizza Build();
}
