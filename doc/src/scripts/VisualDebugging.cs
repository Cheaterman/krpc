using KRPC.Client;
using KRPC.Client.Services.SpaceCenter;
using KRPC.Client.Services.Drawing;

class VisualDebugging
{
    public static void Main ()
    {
        var conn = new Connection ("Visual Debugging");
        var vessel = conn.SpaceCenter ().ActiveVessel;

        var refFrame = vessel.Orbit.Body.ReferenceFrame;
        var velocity = vessel.Flight (refFrame).Velocity;
        conn.Drawing ().AddDirection(velocity, refFrame);

        while (true) {
        }
    }
}
