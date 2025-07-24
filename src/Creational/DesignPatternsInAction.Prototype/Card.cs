namespace DesignPatternsInAction.Prototype;

public class Card : IUIComponent
{
    public string Title { get; set; }
    public string Content { get; set; }

    public IUIComponent Clone()
    {
        return new Card
        {
            Title = this.Title,
            Content = this.Content
        };
    }

    public void Render()
    {
        Console.WriteLine($"[Card] Title: {Title}, Content: {Content}");
    }
}
