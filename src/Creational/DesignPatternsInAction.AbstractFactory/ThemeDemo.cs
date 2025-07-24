namespace DesignPatternsInAction.AbstractFactory;

public static class ThemeDemo
{
    public static void RenderUI(IThemeFactory factory)
    {
        var button = factory.CreateButton();
        var checkbox = factory.CreateCheckbox();

        button.Render();
        checkbox.Render();
    }
}
