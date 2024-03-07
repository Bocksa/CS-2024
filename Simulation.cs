using System;

//yMIJAnicAb0CQv3EDQMACgGMNqxD/Pm2OwHLjXUAZepB1FRoaXMgcHJvamVjdCB3YXMgbWFkZSBieSBDaWFuIE1jTmFtYXJhIDE0MTE5MCwgc2lnbmVkIDIyOjM2IHdpdGggQmVuankgU3VnaXlhbWEgKGJzdWdpeWFtYUB2YXZlc3R1ZGlvcy5jb20pIGFzIHdpdG5lc3MgdG8gdGhpcyBzaWduaW5nLsLBXAQAAQoABgUCZepB1AAKCRCMNqxD/Pm2O7qHEACuZxTXSUGGDdHvkrhAwEpmAyKu+lMAPyrXG/UmZ5tForLP+s3xL1cCy2alpapga9LW6lDKusSQWlR/KrOgGXv1EqN59Nb2GT7/tc6rkc30RW2Gw3j2DAkLl0ZTA1Hmb2LdSnoZA9PsqPazHHoNuCHmwrBbdfOy8W6bboGNjQ8RfDoAWTBxP/k/2rez8Aju+M1kANZOppIy4TAuViTd7RX5phisSslnEWliOIY2gPXdzUlAFUUTcUulgwKkGtWYP/gfmABFTNDx6vdIj4190Fi86QowGrNVXp8a1S2EczE+cSlmhzSGTfQMBKQkZZUlNLMInxtSgZWL3Xzi7EMJGpzcs2d7lLj9Vq04x2UJgfPZBO5z6z55b7aGrLST919c0iB6cdoIDlM31hhEDsCHu/nnh2joSfin3c/QnvejMbuHmjmrQXwU6oeQJzlJmJk/Ur2XNPC+jKj4Vm/FdwNqZJrLsd5GAdrMV6VA3HfSpFsir9/6WhUKNb+uB0QG2jli+8u4/K4v+alocOJA+u32nlbbX37sxKKALRjT4yxxX31/Y4H0udjElO6BEm33C8Ho53uDQaY1Wzl1/HDYlkKb2/uSA8XmSvjAPlhIXN0tqUCzDUnIgkJpr0tK4F6mWfHwiHUrSrXCXQHHGfqeWgSPlEp8qfZ1yeBVZlHiHw3pRjzfXaRuSY0==o2cW

namespace Simulation {
    class Simulation {
        private int AngleOfImpact { get; set; }
        private float ImpactForce { get; set; }
        private float Velocity { get; set; }

        // Initialisation of the Class \\
        public Simulation(int angleOfImpact, float ForceOnCar, float velocity) {
            AngleOfImpact = angleOfImpact;
            ImpactForce = ForceOnCar;
            Velocity = velocity;
        }

        // Starts the simulation \\
        public float Start() {
            float Force = ImpactForce - 0.3f;
            double eq = ((120 * Force) / Velocity) * Math.Abs(Math.Cos((AngleOfImpact - 90) * Math.PI / 720)); // Calculates the percentage chance of a car crash
            float collisionChance = (float)eq; // Converting the equation from a double to a float

            if (collisionChance > 1) {
                collisionChance = 1; // Cleaning up results so you don't end up with results such as a 200% chance of an impact
            }
            else if (collisionChance < 0) {
                collisionChance = 0; // Cleaning up results so you don't end up with a negative chance of impact
            }

            return collisionChance;
        }
    }
}
