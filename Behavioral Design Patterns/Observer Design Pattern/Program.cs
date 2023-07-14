using Observer_Design_Pattern.Models;

InventoryInfoPublisher publisher = new InventoryInfoPublisher();

CustomerObserver cus1 = new CustomerObserver(publisher, "Anshul");
CustomerObserver cus2 = new CustomerObserver(publisher, "Ayush");
CustomerObserver cus3 = new CustomerObserver(publisher, "Rohit");

publisher.UpdateInventory(11);

cus1.Buy(3);
cus2.Buy(2);
cus3.Buy(5);