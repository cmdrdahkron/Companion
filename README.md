# Companion

An alternative to Voice Attack.

## Current status

**Companion is currently experimental and not in a working state ready for public consumption.** Feel free to grab the source and play with it, but there isn't a lot to play with yet.

## Why create an alternative?

My frustration with Voice Attack came from using (and tweaking) the advanced beta profile in the  [Elite: Dangerous voice pack](http://www.elitedangerousvoicepack.com). It's clear what the author is trying to achieve, and having delved in to try to plug some of the holes and fix some of the issues I'm genuinely impressed with their seemingly bottomless pool of patience and pragmatism.

Don't get me wrong, Voice Attack is brilliant and it works perfectly in 90% of cases, however I find it incredibly limited and laborious once you hit a certain level of complexity.

The main cause of pain is the user interface. _So_ much pointing and clicking and incredibly slow list loading. I'm sure the author will address these issues in time, but the point and click approach to defining logic is still inherently limited by the choices provided by the interface, which means if the author hasn't added it then you are out of luck. In addition, Voice Attack profiles become increasingly more difficult to maintain as they grow and repetition creeps in.

So I took it upon myself to decide that whilst Voice Attack fulfils the requirements for its original intention it's not fit for purpose at the level of complexity a decent personality for Elite: Dangerous or Star Citizen needs it to be, and so this project aims to create a framework in which authors can create game companion personalities without limitations.

## How is it different?

Rather than provide a user interface in which to define your logic, Companion incorporates a scripting engine and provides a very simple framework with which to define your logic. If you are new to programming, don't be put off. Everything you already do in the Voice Attack interface translates very easily to Companion and the framework I have provided is simple enough that you'll pick it up in no time.

## Architecture

Companion comprises two parts.  A native part that encapsulates operating system specifics such as interfacing with the speech recognition engine, and a scripted part that encapsulates everything else.  The scripted part is platform agnostic which means that if/when I get around to adding support for other operating systems, existing companion personalities will work without modification.

## Scripting

Companion embeds a Ruby virtual machine.  I chose Ruby because I am already a Ruby developer, because it's embedded easily, and because Ruby is one of the few languages I know that can lend itself so well to non programmers.  Ruby allows me (the programmer) to create a framework in which you (the user) can define configuration, behaviour and other logic using keywords that are already familiar to you.

If you don't have any programming experience, don't worry as you won't need to learn too much Ruby itself.

### Inputs & outputs

It's easiest to visualise the companion framework as a bunch of inputs and outputs where the scripting code simply routes between them.  So you say something that is recognised and the native part informs scripting part, which could then play a sound or virtually click a button (or something).

Inputs include:

 * Speech recognition
 * Keyboard events
 * Joystick events
 * Game data events
 * Game log events

Outputs include:

 * Speech synthesis
 * Playing sounds
 * Virtual key presses
 * Virtual button presses

These are only the inputs and outputs that are built in. Companion uses IronRuby on Windows, which gives it direct and unencumbered access to the entire .NET framework, so it's extendible in as many ways as you can imagine (with some additional programming knowledge).

### Example code

Here we have a simple companion called HAL that responds to a well known quote:

    companion 'HAL' do
      hear "open the pod pay doors HAL" do
        say "I'm sorry, Dave. I'm afraid I can't do that."
      end
    end

We could make it respond differently to different names:

    companion 'HAL' do
      hear "open the pod pay doors (HAL|Bob)" do |name|
        case name
        when 'HAL'
          say "I'm sorry, Dave. I'm afraid I can't do that."
        when 'Bob'
          say "I'm sorry, Susan. I'm afraid I can't do that."
        end
      end
    end

The `(HAL|Bob)` is a pattern that will match either "HAL" or "Bob".

We could make the name optional:

    companion 'HAL' do
      hear "open the pod pay doors (|HAL)" do
        case name
        when 'HAL'
          say "I'm sorry, Dave. I'm afraid I can't do that."
        else
          say ""
      end
    end

Here we are matching "HAL", "Bob" or nothing.

These are just a few rudimentary examples, but you get the idea.  The best source of reference is always going to be my default companion personality, HAL.

## Installing

There's nothing to install yet ;-)
