class Array
  def sample
    self[rand(count)]
  end
end

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

include DSL