using DesignPatternsInAction.AbstractFactory;

Console.WriteLine("== Light Theme ==");
ThemeDemo.RenderUI(new LightThemeFactory());

Console.WriteLine("\n== Dark Theme ==");
ThemeDemo.RenderUI(new DarkThemeFactory());
