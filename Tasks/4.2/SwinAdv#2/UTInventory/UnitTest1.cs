using NUnit.Framework;
using Iteration2;

namespace UnitTestIta2
{
    public class InventoryTests
    {
        private Inventory inventory;
        private Item shovel;
        private Item pc;
        private Item sword;

        [SetUp]
        public void Setup()
        {
            Item shovel = new Item(new string[] { "shovel"," spade"}, "a shovel", "This is a shovel");
            Item sword = new Item(new string[] { "sword", " blade" }, "a sword", "This is a sword");
            Item pc = new Item(new string[] { "pc", " computer" }, "a pc", "This is a computer");
            inventory = new Inventory();
            inventory.Put(shovel);
            inventory.Put(sword);
            inventory.Put(pc);
        }

        [Test]
        public void TestFindItem()
        {
            Assert.IsTrue(inventory.HasItem("shovel"));
            Assert.IsTrue(inventory.HasItem("sword"));
            Assert.IsTrue(inventory.HasItem("pc"));
        }

        [Test]
        public void TestNoFindItem()
        {
            Assert.IsFalse(inventory.HasItem("stick"));  
        }

        [Test]
        public void TestFetchItems()
        {
            Assert.NotNull(inventory.Fetch("shovel"));
            Assert.IsTrue(inventory.HasItem("shovel"));
        }

        [Test]
        public void TestTakeItem()
        {
            Assert.NotNull(inventory.Take("sword"));
            Assert.IsFalse(inventory.HasItem("sword"));
        }

        [Test]
        public void TestItemList()
        {
            string ItemList = "a shovel (shovel)\n a sword (sword)\na small computer(pc)";
            Assert.That(ItemList, Is.EqualTo(ItemList));
        }

    }
}
