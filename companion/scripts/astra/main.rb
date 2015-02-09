###########################################################################
# This here is our 'game code', which provides a nice facade to the game
# and its state.
###########################################################################

# module Elite
#   module Deployable
#     def deployed?
#       !!@deployed
#     end

#     def retracted?
#       !@deployed
#     end

#     def deploy!
#       puts "WARN: #{self} does not implement deploy!"
#     end

#     def retract!
#       puts "WARN: #{self} does not implement retract!"
#     end
#   end

#   module Resettable
#     def reset!
#       puts "WARN: #{self} does not implement reset!"
#     end
#   end

#   class LandingGear
#     include Deployable

#     def deploy!
#       trigger 'landing_gear'
#     end

#     def retract!
#       trigger 'landing_gear'
#     end
#   end

#   class CargoScoop
#   end

#   class HardPoints
#   end

#   class Ship
#     def landing_gear
#       @landing_gear ||= LandingGear.new
#     end

#     def hardpoints
#       @hardpoints ||= HardPoints.new
#     end
#   end
# end

###########################################################################
# This is 'user code', that which is supplied by you, the user.
###########################################################################

# puts $:.inspect

# require 'yaml'

# random_sounds = load_yaml 'random.yml'

# on '(|engines|thrusters) (25|50|75|100) percent' do |thing, num|
#   # play random_sounds['engines']['etd']['increments'][num].sample
#   # trigger "thrusters_#{num}"
# end

# on 'flight assist (|on|off)' do |state|
# end

# on '(go to|engage) jump (|drive)' {
# }

# on '(charge|engage) (|the) F T L' {
# }

# on '(|deploy|retract) landing gear' { |state|
# }

# puts "LOADED!"
