namespace DesignPatternsInAction.AbstractFactory;

public class LightButton : IButton
{
    public void Render()
    {
        Console.WriteLine("[Light Button]");
    }
}
