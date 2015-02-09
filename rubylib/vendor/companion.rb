require 'companion/extensions/array'

module Companion

  class Native
    class << self
      def on(pattern, options = {}, &block)
        puts "Listening: #{pattern}"
        ::Native.On(pattern)
      end

      def say(phrase, options = {}, &block)
        puts "Saying: #{phrase}"
        ::Native.Say(phrase)
      end

      def play(file, options = {}, &block)
        puts "Playing: #{file}"
        ::Native.Play(file)
      end
    end
  end

  module DSL
    def game(name)
    end

    def bind(event, options = {}, &block)
    end

    def log(message)
      ::Kernel.puts(message)
    end

    def hear(pattern, options = [], &block)
      Companion::Native.on(pattern, options, &block)
    end

    def play(file, options = {}, &block)
      Companion::Native.play(file, options, &block)
    end

    def say(phrase, options = [], &block)
      Companion::Native.say(phrase, options, &block)
    end

    def base_dir
      File.expand_path(File.dirname(__FILE__))
    end

    def load_yaml(file)
      YAML.load_file File.join(base_dir, file)
    end

    # def set(name, value)
    #   ::Native.vars
    # end
  end

  class Builder < BasicObject
    include DSL

    attr_reader :name

    def initialize(name)
      @name = name
    end

    def self.build(name, &block)
      self.new(name).instance_eval(&block)
    end
  end

  class << self
    def build(name, &block)
      object = BasicObject.new
      object.__send__(:include, Companion::DSL)
      object.instance_eval(&block)
    end
  end

end

def companion(name, game = 'generic', &block)
  Companion::Builder.build(name, &block)
end
