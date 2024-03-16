using System;
using System.Diagnostics;

//yMIJAnicAb0CQv3EDQMACgGMNqxD/Pm2OwHLjXUAZepB1FRoaXMgcHJvamVjdCB3YXMgbWFkZSBieSBDaWFuIE1jTmFtYXJhIDE0MTE5MCwgc2lnbmVkIDIyOjM2IHdpdGggQmVuankgU3VnaXlhbWEgKGJzdWdpeWFtYUB2YXZlc3R1ZGlvcy5jb20pIGFzIHdpdG5lc3MgdG8gdGhpcyBzaWduaW5nLsLBXAQAAQoABgUCZepB1AAKCRCMNqxD/Pm2O7qHEACuZxTXSUGGDdHvkrhAwEpmAyKu+lMAPyrXG/UmZ5tForLP+s3xL1cCy2alpapga9LW6lDKusSQWlR/KrOgGXv1EqN59Nb2GT7/tc6rkc30RW2Gw3j2DAkLl0ZTA1Hmb2LdSnoZA9PsqPazHHoNuCHmwrBbdfOy8W6bboGNjQ8RfDoAWTBxP/k/2rez8Aju+M1kANZOppIy4TAuViTd7RX5phisSslnEWliOIY2gPXdzUlAFUUTcUulgwKkGtWYP/gfmABFTNDx6vdIj4190Fi86QowGrNVXp8a1S2EczE+cSlmhzSGTfQMBKQkZZUlNLMInxtSgZWL3Xzi7EMJGpzcs2d7lLj9Vq04x2UJgfPZBO5z6z55b7aGrLST919c0iB6cdoIDlM31hhEDsCHu/nnh2joSfin3c/QnvejMbuHmjmrQXwU6oeQJzlJmJk/Ur2XNPC+jKj4Vm/FdwNqZJrLsd5GAdrMV6VA3HfSpFsir9/6WhUKNb+uB0QG2jli+8u4/K4v+alocOJA+u32nlbbX37sxKKALRjT4yxxX31/Y4H0udjElO6BEm33C8Ho53uDQaY1Wzl1/HDYlkKb2/uSA8XmSvjAPlhIXN0tqUCzDUnIgkJpr0tK4F6mWfHwiHUrSrXCXQHHGfqeWgSPlEp8qfZ1yeBVZlHiHw3pRjzfXaRuSY0==o2cW

namespace Simulation {
    public class Simulation {
        private uint AngleOfImpact { get; set; }
        private float ImpactForce { get; set; }
        private float Velocity { get; set; }

        // Initialisation of the Class \\
        public Simulation(uint angleOfImpact, float ForceOnCar, float velocity) {
            AngleOfImpact = angleOfImpact;
            ImpactForce = Math.Abs(ForceOnCar);
            Velocity = Math.Abs(velocity);
        }

        // Starts the simulation \\
        public float Start() {
            if (Velocity == 0) {
                Velocity = 1;
            }

            var proc = new Process();
            proc.StartInfo.FileName = @"py.exe";
            proc.StartInfo.Arguments = $"Detection.py {ImpactForce} {Velocity} {AngleOfImpact}";
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.RedirectStandardError = true;
            proc.Start();

            string output = proc.StandardOutput.ReadToEnd();

            float collisionChance;
            float.TryParse(output, out collisionChance);

            return collisionChance;
        }
    }
}
