$: << File.join(File.dirname(__FILE__), 'rubylib', 'vendor')

require 'companion'

base_dir    = File.expand_path(File.dirname(__FILE__))
scripts_dir = File.join(base_dir, 'scripts')

Dir.chdir(base_dir) do
  Dir["#{scripts_dir}/**/*.rb"].each { |f| load f }
end