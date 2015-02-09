base_dir    = File.expand_path(File.dirname(__FILE__))
scripts_dir = File.join(base_dir, 'scripts')

$: << File.join(base_dir, 'rubylib', 'vendor')

require 'companion'

load "#{scripts_dir}/hal/hal.rb"
