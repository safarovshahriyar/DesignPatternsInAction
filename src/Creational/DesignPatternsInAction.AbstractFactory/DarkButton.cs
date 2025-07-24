﻿namespace DesignPatternsInAction.AbstractFactory;

public class DarkButton : IButton
{
    public void Render()
    {
        Console.WriteLine("[Dark Button]");
    }
}
