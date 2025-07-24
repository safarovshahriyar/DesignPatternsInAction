namespace DesignPatternsInAction.AbstractFactory;

public class LightCheckbox : ICheckbox
{
    public void Render()
    {
        Console.WriteLine("[Light Checkbox]");
    }
}
