using System.Text;

namespace DesignPatternsInAction.Builder;

public class Pizza
{
    private readonly List<string> _ingredients = new();

    public void AddIngredient(string ingredient)
    {
        _ingredients.Add(ingredient);
    }

    public string Describe()
    {
        var sb = new StringBuilder();
        sb.AppendLine("Pizza with:");
        foreach (var item in _ingredients)
        {
            sb.AppendLine($" - {item}");
        }
        return sb.ToString();
    }
}
