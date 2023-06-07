using Factory_Design_Pattern.Factory;
using Interface;

IProduct productA = ProductFactory.GetProduct('A');
IProduct productB = ProductFactory.GetProduct('B');
IProduct productC = ProductFactory.GetProduct('C');

productA.GetProductInfo();
productB.GetProductInfo();
productC.GetProductInfo();

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
