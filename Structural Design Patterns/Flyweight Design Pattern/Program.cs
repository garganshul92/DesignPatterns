using Flyweight_Design_Pattern.Interfaces;
using Flyweight_Design_Pattern.Models;


//Flywight design pattern is also called cache.
ShapeFactory shapeFactory = new ShapeFactory();
IShape shape = shapeFactory.GetShape("rectangle");
shape.Draw();
shape = shapeFactory.GetShape("rectangle");
shape.Draw();
shape = shapeFactory.GetShape("rectangle");
shape.Draw();
shape = shapeFactory.GetShape("circle");
shape.Draw(); 
shape = shapeFactory.GetShape("circle");
shape.Draw(); 
shape = shapeFactory.GetShape("circle");
shape.Draw();

shapeFactory.GetNumberOfObjects();