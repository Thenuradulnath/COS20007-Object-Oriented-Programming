using ClockTask;
using CounterTask;
using System.Diagnostics.Metrics;

namespace TestClock
{
    public class Tests
    {
            public Clock clock;

            [SetUp]
            public void Setup()
            {
                clock = new Clock();
            }

            [Test]
            public void TestTimeReal()
            {
                Assert.That(clock.Time(), Is.EqualTo("00:00:00"));
            }

            [Test]
            public void TestTickSecond()
            {
                clock.Tick();
                Assert.That(clock.Time(), Is.EqualTo("00:00:01"));
            }

            [Test]
            public void TestTickMinute()
            {
                for (int i = 0; i < 60; i++)
                {
                    clock.Tick();
                }
                Assert.That(clock.Time(), Is.EqualTo("00:01:00"));
            }
            
            [Test]
            public void TestTickHour()
            {
            for (int i = 0; i < 3600; i++)
            {
                clock.Tick();
            }
                Assert.That(clock.Time(), Is.EqualTo("01:00:00"));
            }
    }
    }