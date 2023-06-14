﻿using Decorator_Design_Pattern.Interfaces;

namespace Decorator_Design_Pattern.Models;

public class RedBorderShape : ShapeDecorator
{
    public RedBorderShape(IShape shape) : base(shape)
    {  
    }

    public override void Draw()
    {
        base.Draw();
        SetBorderColor();
    }

    private void SetBorderColor()
    {
        Console.WriteLine("Added RedColor Border to the shape.");
    }
}
