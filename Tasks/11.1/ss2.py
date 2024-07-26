class Counter
    def initialize(value = 0, max_value = 100)
        @value = value
        @max_value = max_value
    end

    def increment
        @value += 1
        if @value >= @max_value
            @value = 0
        end
    end

    def value
        @value
    end
end

class Clock
    def initialize
        @hours = Counter.new(0, 24)
        @minutes = Counter.new(0, 60)
        @seconds = Counter.new(0, 60)
    end

    def tick
        @seconds.increment
        if @seconds.value == 0
            @minutes.increment
            if @minutes.value == 0
                @hours.increment
            end
        end
    end

    def display_time
        sprintf("%02d:%02d:%02d", @hours.value, @minutes.value, @seconds.value)
    end
end

# Example usage
clock = Clock.new
3661.times { clock.tick }
puts clock.display_time
