namespace Ludo
{
    partial class PlayerSelection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxRed = new System.Windows.Forms.CheckBox();
            this.checkBoxBlue = new System.Windows.Forms.CheckBox();
            this.checkBoxYellow = new System.Windows.Forms.CheckBox();
            this.checkBoxGreen = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(811, 27);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(649, 236);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Visible = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please select your color: ";
            // 
            // checkBoxRed
            // 
            this.checkBoxRed.AutoSize = true;
            this.checkBoxRed.BackColor = System.Drawing.Color.Red;
            this.checkBoxRed.Location = new System.Drawing.Point(77, 109);
            this.checkBoxRed.Name = "checkBoxRed";
            this.checkBoxRed.Size = new System.Drawing.Size(59, 21);
            this.checkBoxRed.TabIndex = 3;
            this.checkBoxRed.Text = "RED";
            this.checkBoxRed.UseVisualStyleBackColor = false;
            this.checkBoxRed.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxBlue
            // 
            this.checkBoxBlue.AutoSize = true;
            this.checkBoxBlue.BackColor = System.Drawing.Color.Blue;
            this.checkBoxBlue.Location = new System.Drawing.Point(77, 151);
            this.checkBoxBlue.Name = "checkBoxBlue";
            this.checkBoxBlue.Size = new System.Drawing.Size(66, 21);
            this.checkBoxBlue.TabIndex = 4;
            this.checkBoxBlue.Text = "BLUE";
            this.checkBoxBlue.UseVisualStyleBackColor = false;
            this.checkBoxBlue.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBoxYellow
            // 
            this.checkBoxYellow.AutoSize = true;
            this.checkBoxYellow.BackColor = System.Drawing.Color.Yellow;
            this.checkBoxYellow.Location = new System.Drawing.Point(77, 189);
            this.checkBoxYellow.Name = "checkBoxYellow";
            this.checkBoxYellow.Size = new System.Drawing.Size(88, 21);
            this.checkBoxYellow.TabIndex = 5;
            this.checkBoxYellow.Text = "YELLOW";
            this.checkBoxYellow.UseVisualStyleBackColor = false;
            this.checkBoxYellow.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBoxGreen
            // 
            this.checkBoxGreen.AutoSize = true;
            this.checkBoxGreen.BackColor = System.Drawing.Color.YellowGreen;
            this.checkBoxGreen.Location = new System.Drawing.Point(77, 227);
            this.checkBoxGreen.Name = "checkBoxGreen";
            this.checkBoxGreen.Size = new System.Drawing.Size(79, 21);
            this.checkBoxGreen.TabIndex = 6;
            this.checkBoxGreen.Text = "GREEN";
            this.checkBoxGreen.UseVisualStyleBackColor = false;
            this.checkBoxGreen.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // PlayerSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 538);
            this.Controls.Add(this.checkBoxGreen);
            this.Controls.Add(this.checkBoxYellow);
            this.Controls.Add(this.checkBoxBlue);
            this.Controls.Add(this.checkBoxRed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnExit);
            this.Name = "PlayerSelection";
            this.Text = "Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.CheckBox checkBoxGreen;
        public System.Windows.Forms.CheckBox checkBoxRed;
        public System.Windows.Forms.CheckBox checkBoxBlue;
        public System.Windows.Forms.CheckBox checkBoxYellow;
    }
}

