###
# HAL 9000 - my test companion personality.
#

companion "hal" do

  game "elite"

  bind "LandingGearToggle" do
    if game.landing_gear.deployed?
      say "Retracting the landing gear"
    else
      say "Deploying the landing gear"
    end
    elite.landing_gear.toggle!
  end

  # event ""

  hear "open the pod pay doors (|HAL)" do
    say "I'm sorry, Dave. I'm afraid I can't do that."
  end

  hear "(|engines|thrusters) (25|50|75|100) percent" do |thing, num|
    thing ||= ["engine", "thrusters"].sample
    say "Setting #{thing} to #{num} percent"
  end

  hear "flight assist (|on|off)" do |state|
    say "toggling flight assist #{state}"
  end

  hear "(go to|engage) jump (|drive)" do
    say "Engaging jump drive"
  end

  hear "(charge|engage) (|the) F T L" do
    say "Engaging the F T L drive"
  end

  hear "(|deploy|retract) landing gear" do |state|
    if state
      if game.landing_gear.deployed?
      else
      end
    else
      game.landing_gear.toggle!
    end
  end

end
