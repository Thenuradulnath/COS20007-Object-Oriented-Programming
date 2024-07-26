using NUnit.Framework;
using Iteration2;
using NuGet.Frameworks;

namespace UnitTestIta2
{
    public class UTPlayer
    {
        private Player player;
        [SetUp]
        public void Setup()
        {
            player = new Player("fred", "the mighty programmer");
            player.Inventory.Put(new Item(new string[] { "shovel", "spade" }, " a shovel", "This is a fine shovel"));
            player.Inventory.Put(new Item(new string[] { "sword", "blade" }, " a sword", "This is a fine sword"));
            player.Inventory.Put(new Item(new string[] { "pc", "computer" }, " a computer", "This is a fine computer"));
        }

        [Test]
        public void TestPlayerIden()
        {
            Assert.IsTrue(player.AreYou("me"));
            Assert.IsTrue(player.AreYou("inventory"));
        }

        [Test]
        public void TestPlayerLocateItems()
        {
            Assert.IsTrue(player.Locate("shovel").AreYou("shovel"));
            Assert.IsTrue(player.Locate("sword").AreYou("sword"));
            Assert.IsTrue(player.Locate("pc").AreYou("pc"));
        }
        [Test]
        public void TestPlayerLocateMe() 
        {
            Assert.IsTrue(player.Locate("me").AreYou("me"));
            Assert.IsTrue(player.Locate("inventory").AreYou("inventory"));
        }
        [Test]
        public void TestLocateNothing() 
        {
            Assert.IsNull(player.Locate("stick"));
        }
        [Test]
        public void TestFullDescription() 
        {
            string pFullDescription = "You are fred the mighty programmer. You are carrying \n a shovel (shovel)\n a sword (sword)\n a computer (pc)\n";
            Assert.That(player.FullDescription,Is.EqualTo(pFullDescription));
        }
    }
}