local krpc = require 'krpc'
local conn = krpc.connect('Surface speed')
local vessel = conn.space_center.active_vessel
local ref_frame = vessel.orbit.body.reference_frame

while true do
    velocity = vessel:flight(ref_frame).velocity
    print('Surface velocity =', velocity[1], velocity[2], velocity[3])

    speed = vessel:flight(ref_frame).speed
    print('Surface speed = ' .. speed .. ' m/s')

    krpc.platform.sleep(1)
end
