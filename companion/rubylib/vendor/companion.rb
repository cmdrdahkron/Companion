require 'companion/extensions/array'

module Companion

  module DSL
    def sub(name, &block)
    end

    def on(pattern, &block)
      # ::Native.On pattern, values
      yield '25'
    end

    def play(file)
      puts "Playing sound #{file}"
    end

    def say(phrase)
      puts "Saying: #{phrase}"
    end

    def base_dir
      File.expand_path(File.dirname(__FILE__))
    end

    def load_yaml(file)
      YAML.load_file File.join(base_dir, file)
    end

    def set(name, value)
      ::Native.vars
    end
  end

  class Builder < BasicObject
    include DSL

    attr_reader :name

    def initialize(name)
      @name = name
    end

    def self.build(name, &block)
      self.new.instance_eval(&block)
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

def companion(name, &block)
  Companion.build(name, &block)
end
