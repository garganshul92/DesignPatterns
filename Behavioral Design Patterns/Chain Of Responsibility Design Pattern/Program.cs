using Chain_Of_Responsibility_Design_Pattern.Interfaces;
using Chain_Of_Responsibility_Design_Pattern.Models;

IApprover clerk = new Clerk();
IApprover manager = new Manager();
IApprover director = new Director();
clerk.SetNextApprover(manager);
manager.SetNextApprover(director);

PurchaseItem item1 = new PurchaseItem("item1", 9000);
PurchaseItem item2 = new PurchaseItem("item2", 19000);
PurchaseItem item3 = new PurchaseItem("item3", 30000);
PurchaseItem item4 = new PurchaseItem("item4", 90000);

clerk.Approve(item1);
clerk.Approve(item2);
clerk.Approve(item3);
clerk.Approve(item4);