module Elite
  module Deployable

    def deployed?
      !!@deployed
    end

    def retracted?
      !@deployed
    end

    def deploy!
      puts "WARN: #{self} does not implement deploy!"
    end

    def retract!
      puts "WARN: #{self} does not implement retract!"
    end
  end

  module Resettable
    def reset!
      puts "WARN: #{self} does not implement reset!"
    end
  end

  class LandingGear
    include Deployable

    def deploy!
      trigger 'landing_gear'
    end

    def retract!
      trigger 'landing_gear'
    end
  end

  class CargoScoop
  end

  class HardPoints
  end

  class Ship
    def landing_gear
      @landing_gear ||= LandingGear.new
    end

    def hardpoints
      @hardpoints ||= HardPoints.new
    end
  end

end
