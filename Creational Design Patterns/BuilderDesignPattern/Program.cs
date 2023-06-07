using BuilderDesignPattern.ConcreteBuilders;
using BuilderDesignPattern.Models;

Director director1 = new Director(new ConcreteBuilder1());
Director director2 = new Director(new ConcreteBuilder2());
var mvpproduct1 = director1.GetMVPProduct();
var mvpproduct2 = director2.GetMVPProduct();

Console.WriteLine("MVP Products: ");
Console.WriteLine(mvpproduct1.ListParts());
Console.WriteLine(mvpproduct2.ListParts());

var fullproduct1 = director1.GetFullProduct();
var fullproduct2 = director2.GetFullProduct();

Console.WriteLine("------------------------------------");
Console.WriteLine("Full Products: ");
Console.WriteLine(fullproduct1.ListParts());
Console.WriteLine(fullproduct2.ListParts());