class Counter:
    def __init__(self, max_value, initial_value=0):
        self.value = initial_value
        self.max_value = max_value

    def increment(self):
        self.value = (self.value + 1) % self.max_value

    def set_value(self, value):
            self.value = value

    def get_value(self):
        return self.value

class Clock:
    def __init__(self, hours=0, minutes=0, seconds=0):
        self.hours = Counter(24, hours)
        self.minutes = Counter(60, minutes)
        self.seconds = Counter(60, seconds)

    def tick(self):
        self.seconds.increment()
        if self.seconds.get_value() == 0:
            self.minutes.increment()
            if self.minutes.get_value() == 0:
                self.hours.increment()

    def set_time(self, hours, minutes, seconds):
        self.hours.set_value(hours)
        self.minutes.set_value(minutes)
        self.seconds.set_value(seconds)

    def display_time(self):
        return f"{self.hours.get_value():02}:{self.minutes.get_value():02}:{self.seconds.get_value():02}"

if __name__ == "__main__":
    clock = Clock()
    
    clock.set_time(11, 40, 00)

    for _ in range(1000):
        clock.tick()
        print(clock.display_time())
