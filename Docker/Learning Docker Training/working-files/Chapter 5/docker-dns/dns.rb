require 'sinatra'
require 'socket'

set :bind, '0.0.0.0'

get '/' do
  "You found me! My IP is #{Socket.ip_address_list[1].ip_address}"
end
