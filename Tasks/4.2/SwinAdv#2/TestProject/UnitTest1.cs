using NUnit.Framework;
using Ita

    public class Tests
    {
        public IdentifiableObject id1;
        public IdentifiableObject id2;

        [SetUp]
        public void Setup()
        {
            id1 = new IdentifiableObject(new string[] { "fred", "bob" });
            id2 = new IdentifiableObject(new string[] { });
        }

        [Test]
        public void TestAreYou()
        {
            Assert.That(id1.AreYou("bob"), Is.True);
            Assert.That(id1.AreYou("fred"), Is.True);
        }

        [Test]
        public void TestNotAreYou()
        {
            Assert.That(id1.AreYou("wilma"), Is.False);
        }

        [Test]
        public void TestCaseSensitive()
        {
            Assert.That(id1.AreYou("FRED"), Is.True);
            Assert.That(id1.AreYou("bOB"), Is.True);
        }

        [Test]
        public void TestFirstID()
        {
            Assert.That(id1.FirstID, Is.EqualTo("fred"));
        }

        [Test]
        public void TestNoLastID()
        {
            Assert.That(id2.FirstID, Is.EqualTo(""));
        }

        [Test]
        public void TestAddID()
        {
            id1.AddIdentifier("Wilma");

            Assert.That(id1.AreYou("bob"), Is.True);
            Assert.That(id1.AreYou("fred"), Is.True);
            Assert.That(id1.AreYou("wilma"), Is.True);
        }
    }
