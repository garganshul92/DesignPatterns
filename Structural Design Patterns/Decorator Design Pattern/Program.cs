using Decorator_Design_Pattern.Models;

var redBorderRectangle = new RedBorderShape(new RectangularShape());
var redBorderCircle = new RedBorderShape(new CircularShape());

var greenBorderRectangle = new GreenBorderShape(new RectangularShape());
var greenBorderCircle = new GreenBorderShape(new CircularShape());

redBorderRectangle.Draw();

Console.WriteLine("\n\n----------\n\n");

redBorderCircle.Draw();

Console.WriteLine("\n\n----------\n\n");

greenBorderRectangle.Draw();

Console.WriteLine("\n\n----------\n\n");

greenBorderCircle.Draw();
