using Abstract_Factory_Design_Pattern.ConcreteClasses;
using Abstract_Factory_Design_Pattern.Interfaces;

IProductAbstractFactory abstractFactory = new ProductAbstractFactory();
var productAFactory = abstractFactory.GetProductFactory('A');
var productAType1 = productAFactory.GetProduct('1');
var productAType2 = productAFactory.GetProduct('2');

var productBFactory = abstractFactory.GetProductFactory('B');
var productBType1 = productBFactory.GetProduct('1');
var productBType2 = productBFactory.GetProduct('2');

productAType1.GetProductDetails();
productAType2.GetProductDetails();
productBType1.GetProductDetails();
productBType2.GetProductDetails();
