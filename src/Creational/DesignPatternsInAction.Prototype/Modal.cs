namespace DesignPatternsInAction.Prototype;

public class Modal : IUIComponent
{
    public string Header { get; set; }
    public string Body { get; set; }

    public IUIComponent Clone()
    {
        return new Modal
        {
            Header = this.Header,
            Body = this.Body
        };
    }

    public void Render()
    {
        Console.WriteLine($"[Modal] Header: {Header}, Body: {Body}");
    }
}
