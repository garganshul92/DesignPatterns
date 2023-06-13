using Composite_Design_Pattern.Models;

var gift1 = new GiftLeaf(10);
var gift2 = new GiftLeaf(15);
var gift3 = new GiftLeaf(11);
var gift4 = new GiftLeaf(13);

var giftBox1 = new GiftBox();
giftBox1.AddGift(gift1);
giftBox1.AddGift(gift2);

var giftBox2 = new GiftBox();
giftBox2.AddGift(gift3);
giftBox2.AddGift(gift4);

var gift5 = new GiftLeaf(14);
var gift6 = new GiftLeaf(16);

var giftBox3 = new GiftBox();
giftBox3.AddGift(gift5);
giftBox3.AddGift(giftBox1);
giftBox3.AddGift(giftBox2);


var giftBox4 = new GiftBox();
giftBox4.AddGift(gift6);
giftBox4.AddGift(giftBox3);

Console.WriteLine(giftBox4.GetPrice());