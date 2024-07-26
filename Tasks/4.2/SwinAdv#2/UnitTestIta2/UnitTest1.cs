using NUnit.Framework;
using Iteration2;

namespace UnitTestIta2
{
    public class ItemTests
    {
        Item shovel = new Item(new string[] { "shovel" }, "a shovel", "This is a shovel");
        Item sword = new Item(new string[] { "sword" }, "a sword", "This is a sword");


        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void TestItemIdentifiable()
        {
            var result = shovel.AreYou("sword");
            Assert.IsFalse(result); //Item cannot be defined

            var result2 = shovel.AreYou("shovel");
            Assert.IsTrue(result2);

        }

        [Test]
        public void TestShortDescription()
        {
            Assert.AreEqual(shovel.ShortDescription, "a shovel (shovel)"); //Description Correct!
            Assert.AreNotEqual(shovel.ShortDescription, "This is a shovel"); //Testing short with long Description showing they are not Correct!
        }

        [Test]
        public void TestFullDescription()
        {
            Assert.AreEqual(shovel.FullDescription, "This is a shovel"); //Full Description is Correct!
            Assert.AreNotEqual(shovel.FullDescription, "a shovel (shovel)"); //Full Description is not Correct!

        }
    }
}