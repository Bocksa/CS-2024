using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;


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
                string ImpactNumbers = Regex.Replace(ImpactForceBox.Text, "[^0-9.]", "");
                string VelocityNumbers = Regex.Replace(VelocityBox.Text, "[^0-9.]", "");

                ImpactForceBox.Text = ImpactNumbers;
                VelocityBox.Text = VelocityNumbers;

                if (ImpactForceBox.Text == string.Empty) {
                    ImpactForceBox.Text = "0";
                }

                if (VelocityBox.Text == string.Empty) {
                    VelocityBox.Text = "0";
                }

                var simulation = new Simulation.Simulation(trackBar1.Value, Convert.ToSingle(ImpactForceBox.Text), Convert.ToSingle(VelocityBox.Text));

                Results.Text = $"Chance of crash: {simulation.Start().ToString("0.00")}%";
                runButton.Text = "Reload Simulation";
            } else {
                runButton.Text = "Run Simulation";
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e) {
            int angle = trackBar1.Value;
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
