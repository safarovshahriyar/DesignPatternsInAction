namespace DesignPatternsInAction.Prototype;

public static class UIPrototypeDemo
{
    public static void Run()
    {
        Console.WriteLine("== UI Component Cloning (Prototype Pattern) ==\n");

        var originalButton = new Button { Label = "Submit", Color = "Blue" };
        var clonedButton = originalButton.Clone();

        var originalCard = new Card { Title = "Welcome", Content = "Hello, user!" };
        var clonedCard = originalCard.Clone();

        var originalModal = new Modal { Header = "Logout", Body = "Are you sure?" };
        var clonedModal = originalModal.Clone();

        var components = new List<IUIComponent> { originalButton, clonedButton, originalCard, clonedCard, originalModal, clonedModal };

        foreach (var component in components)
        {
            component.Render();
        }
    }
}
