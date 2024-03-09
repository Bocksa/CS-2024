namespace CS2024 {
    partial class Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.CollisionAngle = new System.Windows.Forms.TrackBar();
            this.runButton = new System.Windows.Forms.Button();
            this.DegreeLabel = new System.Windows.Forms.Label();
            this.ImpactForceBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Results = new System.Windows.Forms.Label();
            this.VelocityBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CollisionAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CollisionAngle
            // 
            this.CollisionAngle.Location = new System.Drawing.Point(487, 406);
            this.CollisionAngle.Maximum = 180;
            this.CollisionAngle.Name = "CollisionAngle";
            this.CollisionAngle.Size = new System.Drawing.Size(301, 45);
            this.CollisionAngle.TabIndex = 0;
            this.CollisionAngle.Tag = "yMIJAnicAb0CQv3EDQMACgGMNqxD/Pm2OwHLjXUAZepB1FRoaXMgcHJvamVjdCB3";
            this.CollisionAngle.TickStyle = System.Windows.Forms.TickStyle.None;
            this.CollisionAngle.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(333, 393);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(119, 45);
            this.runButton.TabIndex = 1;
            this.runButton.Tag = "yMIJAnicAb0CQv3EDQMACgGMNqxD/Pm2OwHLjXUAZepB1FRoaXMgcHJvamVjdCB3";
            this.runButton.Text = "Run Simulation";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // DegreeLabel
            // 
            this.DegreeLabel.AutoSize = true;
            this.DegreeLabel.Location = new System.Drawing.Point(607, 390);
            this.DegreeLabel.Name = "DegreeLabel";
            this.DegreeLabel.Size = new System.Drawing.Size(56, 13);
            this.DegreeLabel.TabIndex = 2;
            this.DegreeLabel.Tag = "yMIJAnicAb0CQv3EDQMACgGMNqxD/Pm2OwHLjXUAZepB1FRoaXMgcHJvamVjdCB3";
            this.DegreeLabel.Text = "0 Degrees";
            this.DegreeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ImpactForceBox
            // 
            this.ImpactForceBox.Location = new System.Drawing.Point(56, 406);
            this.ImpactForceBox.MaxLength = 8;
            this.ImpactForceBox.Name = "ImpactForceBox";
            this.ImpactForceBox.Size = new System.Drawing.Size(158, 20);
            this.ImpactForceBox.TabIndex = 3;
            this.ImpactForceBox.Tag = "yMIJAnicAb0CQv3EDQMACgGMNqxD/Pm2OwHLjXUAZepB1FRoaXMgcHJvamVjdCB3";
            this.ImpactForceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ImpactForceBox.TextChanged += new System.EventHandler(this.ImpactForceBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 4;
            this.label1.Tag = "yMIJAnicAb0CQv3EDQMACgGMNqxD/Pm2OwHLjXUAZepB1FRoaXMgcHJvamVjdCB3";
            this.label1.Text = "Enter an impact force in terms of G";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(319, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "yMIJAnicAb0CQv3EDQMACgGMNqxD/Pm2OwHLjXUAZepB1FRoaXMgcHJvamVjdCB3";
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Results
            // 
            this.Results.AutoSize = true;
            this.Results.Location = new System.Drawing.Point(330, 366);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(0, 13);
            this.Results.TabIndex = 6;
            this.Results.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VelocityBox
            // 
            this.VelocityBox.Location = new System.Drawing.Point(56, 359);
            this.VelocityBox.MaxLength = 8;
            this.VelocityBox.Name = "VelocityBox";
            this.VelocityBox.Size = new System.Drawing.Size(158, 20);
            this.VelocityBox.TabIndex = 7;
            this.VelocityBox.Tag = "yMIJAnicAb0CQv3EDQMACgGMNqxD/Pm2OwHLjXUAZepB1FRoaXMgcHJvamVjdCB3";
            this.VelocityBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.VelocityBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 8;
            this.label2.Tag = "yMIJAnicAb0CQv3EDQMACgGMNqxD/Pm2OwHLjXUAZepB1FRoaXMgcHJvamVjdCB3";
            this.label2.Text = "Enter a velocity in km/h";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.VelocityBox);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ImpactForceBox);
            this.Controls.Add(this.DegreeLabel);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.CollisionAngle);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Tag = "yMIJAnicAb0CQv3EDQMACgGMNqxD/Pm2OwHLjXUAZepB1FRoaXMgcHJvamVjdCB3";
            this.Text = "2024-219-3-EV-141190";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CollisionAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar CollisionAngle;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Label DegreeLabel;
        private System.Windows.Forms.TextBox ImpactForceBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Results;
        private System.Windows.Forms.TextBox VelocityBox;
        private System.Windows.Forms.Label label2;
    }
}

