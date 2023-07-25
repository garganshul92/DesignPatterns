using Template_Method_Design_Pattern.AbstractClasses;
using Template_Method_Design_Pattern.Models;

AbstractTeaMaker teaMaker = new RedLabelTeaMaker();
teaMaker.TeaMakingTemplate();

Console.WriteLine("--------------------------------------");

teaMaker = new LiptonTeaMaker();
teaMaker.TeaMakingTemplate();

Console.WriteLine("--------------------------------------");

teaMaker = new OrganicIndiaTeaMaker();
teaMaker.TeaMakingTemplate();