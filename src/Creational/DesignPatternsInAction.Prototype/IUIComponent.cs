namespace DesignPatternsInAction.Prototype;

public interface IUIComponent
{
    IUIComponent Clone();
    void Render();
}
