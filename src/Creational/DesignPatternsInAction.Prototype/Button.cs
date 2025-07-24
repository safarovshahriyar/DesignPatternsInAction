namespace DesignPatternsInAction.Prototype;

public class Button : IUIComponent
{
    public string Label { get; set; }
    public string Color { get; set; }

    public IUIComponent Clone()
    {
        return new Button
        {
            Label = this.Label,
            Color = this.Color
        };
    }

    public void Render()
    {
        Console.WriteLine($"[Button] Label: {Label}, Color: {Color}");
    }
}
