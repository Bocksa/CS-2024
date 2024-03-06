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
