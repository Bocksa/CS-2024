using System;

namespace Simulation {
    class Simulation {
        private int AngleOfImpact { get; set; }
        private float ImpactForce { get; set; }
        private float Velocity { get; set; }
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

        public float Start() {
            float Force = (float)ImpactForce;
            float AbsoluteImpactAngle = ((float)Math.Abs(AngleOfImpact));

            float collisionChance = 0;

            if (AbsoluteImpactAngle <= 45) {
                Force = Force - 0.1f;
                collisionChance = (100f / 0.9f) * Force;
            }
            else if (AbsoluteImpactAngle > 45 & AbsoluteImpactAngle <= 135) {
                Velocity = Velocity / 3.6f;
                Force = Force - 0.3f;

                if (Velocity < 4) {
                    if (Force > 0) {
                        collisionChance = 100;
                    }
                } else {
                    collisionChance = (100f / (1.2f + (Velocity / 66.66f))) * Force;
                }
            }
            else if (AbsoluteImpactAngle > 135 & AbsoluteImpactAngle <= 180) {
                Force = Force - 1f;
                collisionChance = (100f / 0.8f) * Force;
            }
            if (collisionChance > 100) {
                collisionChance = 100;
            }
            else if (collisionChance < 0) {
                collisionChance = 0;
            }

            return collisionChance;
        }
    }
}
