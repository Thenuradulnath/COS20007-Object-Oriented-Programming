using Iteration3;

namespace UTbag
{
    public class Tests
    {
        Bag b1;
        Bag b2;
        Item shovel = new Item(new string[] { "shovel" }, "a shovel", "This is a shovel");
        Item sword = new Item(new string[] { "sword" }, "a sword", "This is a sword");
        Item book = new Item(new string[] { "book" }, "a book", "This is a small book");
        Item pc = new Item(new string[] { "pc" }, "a pc", "This is a small computer");

        [SetUp]
        public void Setup()
        {
            b1 = new Bag(new string[] { "bag" }, "a bag", "This is a bag");
            b2 = new Bag(new string[] { "bag1" }, "a bag1", "This is a bag1");
            b1.Inventory.Put(shovel); 
            b1.Inventory.Put(sword);
            b2.Inventory.Put(book);
            b2.Inventory.Put(pc);
        }

        [Test]
        public void TestBagLocatesItems()
        {
            Assert.IsTrue(b1.Inventory.HasItem("sword"));
            Assert.IsTrue(b1.Inventory.HasItem("shovel"));
            

            Assert.IsTrue(b1.Locate(sword.FirstID) == sword); 
            Assert.IsTrue(b1.Locate(shovel.FirstID) == shovel);

        }
        [Test]
        public void TestBagLocateItself()
        {
            Assert.IsTrue(b1.Locate(b1.FirstID) == b1);
            Assert.IsTrue(b1.Locate("bag") == b1);
        }

        [Test]
        public void TestBagLocatesNothing()
        {
            Assert.IsTrue(b2.Locate(shovel.FirstID) == null);
        }

        [Test]
        public void TestBagFullDescription()
        {
            Assert.AreEqual(b1.FullDescription, "a bag, containing:\na shovel (shovel)\na sword (sword)\n");
        }

        [Test]
        public void TestBagInBag()
        {
            b1.Inventory.Put(b2);
            Assert.IsTrue(b1.Locate(b2.FirstID) == b2);
            Assert.IsTrue(b1.Locate(sword.FirstID) == sword);
            Assert.IsFalse(b2.Locate(shovel.FirstID) == shovel);

            Assert.AreEqual(b1.FullDescription, "a bag, containing:\na shovel (shovel)\na sword (sword)\na bag1 (bag1)\n");
            Assert.AreEqual(b2.FullDescription, "a bag1, containing:\na book (book)\na pc (pc)\n");


        }

    }
}