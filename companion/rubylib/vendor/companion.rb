module Companion

  class << self
    def run!(options = {})
      Companion::Core.new(options).run!
    end
  end

  class Core
    def initialize(options)
      @options = options
    end

    def native
      @options[:native] || ::Native
    end
  end

end