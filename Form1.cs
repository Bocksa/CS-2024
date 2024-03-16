using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Model;

//yMIJAnicAb0CQv3EDQMACgGMNqxD/Pm2OwHLjXUAZepB1FRoaXMgcHJvamVjdCB3YXMgbWFkZSBieSBDaWFuIE1jTmFtYXJhIDE0MTE5MCwgc2lnbmVkIDIyOjM2IHdpdGggQmVuankgU3VnaXlhbWEgKGJzdWdpeWFtYUB2YXZlc3R1ZGlvcy5jb20pIGFzIHdpdG5lc3MgdG8gdGhpcyBzaWduaW5nLsLBXAQAAQoABgUCZepB1AAKCRCMNqxD/Pm2O7qHEACuZxTXSUGGDdHvkrhAwEpmAyKu+lMAPyrXG/UmZ5tForLP+s3xL1cCy2alpapga9LW6lDKusSQWlR/KrOgGXv1EqN59Nb2GT7/tc6rkc30RW2Gw3j2DAkLl0ZTA1Hmb2LdSnoZA9PsqPazHHoNuCHmwrBbdfOy8W6bboGNjQ8RfDoAWTBxP/k/2rez8Aju+M1kANZOppIy4TAuViTd7RX5phisSslnEWliOIY2gPXdzUlAFUUTcUulgwKkGtWYP/gfmABFTNDx6vdIj4190Fi86QowGrNVXp8a1S2EczE+cSlmhzSGTfQMBKQkZZUlNLMInxtSgZWL3Xzi7EMJGpzcs2d7lLj9Vq04x2UJgfPZBO5z6z55b7aGrLST919c0iB6cdoIDlM31hhEDsCHu/nnh2joSfin3c/QnvejMbuHmjmrQXwU6oeQJzlJmJk/Ur2XNPC+jKj4Vm/FdwNqZJrLsd5GAdrMV6VA3HfSpFsir9/6WhUKNb+uB0QG2jli+8u4/K4v+alocOJA+u32nlbbX37sxKKALRjT4yxxX31/Y4H0udjElO6BEm33C8Ho53uDQaY1Wzl1/HDYlkKb2/uSA8XmSvjAPlhIXN0tqUCzDUnIgkJpr0tK4F6mWfHwiHUrSrXCXQHHGfqeWgSPlEp8qfZ1yeBVZlHiHw3pRjzfXaRuSY0==o2cW

namespace CS2024 {
    public partial class Main : Form {
        bool Running = false;
        public Main() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void runButton_Click(object sender, EventArgs e) {
            Running = !Running;
            if (Running) {
                string ImpactNumbers = Regex.Replace(ImpactForceBox.Text, "[^0-9.]", ""); // Removes all characters bar the numbers zero to 9 and a decimal point
                string VelocityNumbers = Regex.Replace(VelocityBox.Text, "[^0-9.]", "");

                ImpactForceBox.Text = ImpactNumbers; // Sets the input text box text to its appropriate variable
                VelocityBox.Text = VelocityNumbers;

                if (ImpactForceBox.Text == string.Empty) { // Sanity checking the inputs to see if any input is present, if not default to 0
                    ImpactForceBox.Text = "0";
                }

                if (VelocityBox.Text == string.Empty) {
                    VelocityBox.Text = "0";
                }

                //Initialize Simulation
                var simulation = new Simulation((uint)CollisionAngle.Value, Convert.ToSingle(ImpactForceBox.Text), Convert.ToSingle(VelocityBox.Text)); 

                // Run simulation and set results text
                Results.Text = $"Chance of crash: {(simulation.Start() * 100).ToString("0.00")}%"; // Convert probability to a percentage which the simulation returns
                runButton.Text = "Reload Simulation";
            } else {
                runButton.Text = "Run Simulation";
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e) {
            int angle = CollisionAngle.Value;
            DegreeLabel.Text = $"{angle.ToString()} Degrees";
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void ImpactForceBox_TextChanged(object sender, EventArgs e) {

        }

        private void label1_Click_1(object sender, EventArgs e) {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void pictureBox1_Click(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }
    }
}
