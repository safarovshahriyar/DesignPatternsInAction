namespace DesignPatternsInAction.AbstractFactory;

public class DarkCheckbox : ICheckbox
{
    public void Render()
    {
        Console.WriteLine("[Dark Checkbox]");
    }
}
