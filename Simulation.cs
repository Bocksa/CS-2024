using System;

namespace Simulation {
    class Simulation {
        private int AngleOfImpact { get; set; }
        private float ImpactForce { get; set; }
        private float Velocity { get; set; }

        // Initialisation of the Class \\
        public Simulation(int angleOfImpact, float ForceOnCar) {
            AngleOfImpact = angleOfImpact;
            ImpactForce = ForceOnCar;
            Velocity = 0;
        }
        public Simulation(int angleOfImpact, float ForceOnCar, float velocity) {
            AngleOfImpact = angleOfImpact;
            ImpactForce = ForceOnCar;
            Velocity = velocity;
        }

        // Starts the simulation \\
        public float Start() {
            float Force = ImpactForce;
            float collisionChance = 0;

            if (AngleOfImpact <= 45) {
                Force = Force - 0.1f; // Shifts graph right by 0.1 on the x-axis
                collisionChance = (100f / 0.9f) * Force; // Formula for the collision chance
            }
            else if (AngleOfImpact > 45 & AngleOfImpact <= 135) {
                Velocity = Velocity / 3.6f; // Converts Velocity from kmh^-1 to ms^-1
                Force = Force - 0.3f; // Shifts graph right by 0.3 on the x-axis

                if (Velocity < 4) {
                    if (Force > 0.4) {
                        collisionChance = 100; // If the Velocity is under 4ms^-1
                                               // and the Force is over 0.2g at a 90 degree angle there is no possible
                                               // way for the car to experience that force at a near static speed
                    }
                } else {
                    collisionChance = (100f / (1.2f + (Velocity / 66.66f))) * Force; // Velocity is added in here as lateral forces can be effected
                                                                                     // by a car turning
                }
            }
            else if (AngleOfImpact > 135 & AngleOfImpact <= 180) {
                Force = Force - 1f; // Shifts graph right by 1 on the x-axis
                collisionChance = (100f / 0.8f) * Force; // Formula for the collision chance
            }
            if (collisionChance > 100) {
                collisionChance = 100; // Cleaning up results so you don't end up with results such as a 200% chance of an impact
            }
            else if (collisionChance < 0) {
                collisionChance = 0; // Cleaning up results so you don't end up with a negative chance of impact
            }

            return collisionChance;
        }
    }
}
