using NUnit.Framework;
using QueApplication;

namespace TestQue
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestEnqueue()
        {
            IntegerQueue myQueue = new IntegerQueue();
            myQueue.Enqueue(12345);
            int myCount = myQueue.Count;
            Assert.That(myCount, Is.EqualTo(1));

            Assert.That(myQueue._elements.Count, Is.EqualTo(1));
            Assert.That(myQueue._elements[0], Is.EqualTo(12345));
        }

        [Test]
        public void TestDequeue()
        {
            IntegerQueue myQueue = new IntegerQueue();

            myQueue.Enqueue(10);
            myQueue.Enqueue(20);
            myQueue.Enqueue(30);

            int dequeueResult1 = myQueue.Dequeue();
            int dequeueResult2 = myQueue.Dequeue();
            int dequeueResult3 = myQueue.Dequeue();

            Assert.That(dequeueResult1, Is.EqualTo(10));
            Assert.That(dequeueResult2, Is.EqualTo(20));
            Assert.That(dequeueResult3, Is.EqualTo(30));
        }
    }
}
