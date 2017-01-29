using System;
using KRPC.Client;
using KRPC.Client.Services.SpaceCenter;

class OrbitalSpeed
{
    public static void Main ()
    {
        var connection = new Connection (name : "Orbital speed");
        var vessel = connection.SpaceCenter ().ActiveVessel;
        var refFrame = vessel.Orbit.Body.NonRotatingReferenceFrame;

        while (true) {
            var velocity = vessel.Flight (refFrame).Velocity;
            Console.WriteLine ("Orbital velocity = (" +
                               velocity.Item1 + ", " +
                               velocity.Item2 + ", " +
                               velocity.Item3 + ")");

            var speed = vessel.Flight (refFrame).Speed;
            Console.WriteLine ("Orbital speed = " + speed + " m/s");

            System.Threading.Thread.Sleep (1000);
        }
    }
}
