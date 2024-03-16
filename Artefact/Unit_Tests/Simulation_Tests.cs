using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;

namespace Tests {
    [TestClass]
    public class SimulationTest {
        [TestMethod]
        public void Run_Simulation_WithValidInputs() {
            float ImpactForce = 1.05f;
            float Velocity = 120.5f;
            uint AngleOfImpact = 75;

            float expectedOutput = 0.7453f;

            var simulation = new Simulation(AngleOfImpact, ImpactForce, Velocity);
            var simulationResponse = simulation.Start();
            Assert.AreEqual(expectedOutput, simulationResponse, 0.0001, "Simulation responded incorrectly.");
        }
    }
}
