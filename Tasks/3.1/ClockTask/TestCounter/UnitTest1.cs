using CounterTask;

namespace TestCounter
{
    public class Tests
    {
        public Counter counter;
        [SetUp]
        public void Setup()
        {
            counter = new Counter("Test");
        }
        [Test]
        public void TestTickInitial()
        {
            Assert.That(counter.Ticks, Is.EqualTo(0));
        }

        [Test]
        public void TestIncrementAddOne()
        {
            counter.Increment();
            Assert.That(counter.Ticks, Is.EqualTo(1));
        }

        [Test]
        public void TestIncrement()
        {
            for (int i = 0; i < 5; i++)
            {
                counter.Increment();
            }
            Assert.That(counter.Ticks, Is.EqualTo(5));
        }

        [Test]
        public void TestReset()
        {
            counter.Increment();
            counter.Reset();
            Assert.That(counter.Ticks, Is.EqualTo(0));
        }
    }
 }
