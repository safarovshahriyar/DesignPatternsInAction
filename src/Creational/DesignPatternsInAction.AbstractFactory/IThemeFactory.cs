namespace DesignPatternsInAction.AbstractFactory;

public interface IThemeFactory
{
    IButton CreateButton();
    ICheckbox CreateCheckbox();
}
