namespace DesignPatternsInAction.AbstractFactory;

public class LightThemeFactory : IThemeFactory
{
    public IButton CreateButton() => new LightButton();
    public ICheckbox CreateCheckbox() => new LightCheckbox();
}
