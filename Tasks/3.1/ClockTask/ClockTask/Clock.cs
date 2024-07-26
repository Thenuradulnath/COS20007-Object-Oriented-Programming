using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CounterTask;


namespace ClockTask
{
        public class Clock
        {
            private Counter _second;
            private Counter _minute;
            private Counter _hour;

            public Clock()
            {
                _second = new Counter("second");
                _minute = new Counter("minute");
                _hour = new Counter("hour");
            }


            public void Tick()
            {
                _second.Increment();

                if (_second.Ticks > 59)
                {
                    _minute.Increment();
                    _second.Reset();

                    if (_minute.Ticks > 59)
                    {
                        _hour.Increment();
                        _minute.Reset();

                        if (_hour.Ticks > 23)
                        {
                            Reset();
                        }
                    }
                }
            }

            public void Reset()
            {
                _second.Reset();
                _minute.Reset();
                _hour.Reset();
            }

            public string Time()
            {
                return $"{_hour.Ticks:D2}:{_minute.Ticks:D2}:{_second.Ticks:D2}";
            }
        }
    }
