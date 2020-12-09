namespace Haunted_House_Adventure_Game
{
    partial class Form1
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
            this.labelMessage = new System.Windows.Forms.Label();
            this.labelRed = new System.Windows.Forms.Label();
            this.labelBlue = new System.Windows.Forms.Label();
            this.labelYellow = new System.Windows.Forms.Label();
            this.labelInstructions = new System.Windows.Forms.Label();
            this.yellowButton = new System.Windows.Forms.Label();
            this.blueButton = new System.Windows.Forms.Label();
            this.redButton = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMessage
            // 
            this.labelMessage.BackColor = System.Drawing.Color.Transparent;
            this.labelMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.ForeColor = System.Drawing.Color.Gold;
            this.labelMessage.Location = new System.Drawing.Point(12, 9);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(766, 86);
            this.labelMessage.TabIndex = 0;
            this.labelMessage.Text = "Your friends dared you to enter a haunted house. Will you accept?";
            this.labelMessage.Click += new System.EventHandler(this.Label1_Click);
            // 
            // labelRed
            // 
            this.labelRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRed.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelRed.Location = new System.Drawing.Point(128, 247);
            this.labelRed.Name = "labelRed";
            this.labelRed.Size = new System.Drawing.Size(338, 39);
            this.labelRed.TabIndex = 1;
            this.labelRed.Text = "Yes";
            // 
            // labelBlue
            // 
            this.labelBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBlue.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelBlue.Location = new System.Drawing.Point(128, 300);
            this.labelBlue.Name = "labelBlue";
            this.labelBlue.Size = new System.Drawing.Size(335, 41);
            this.labelBlue.TabIndex = 2;
            this.labelBlue.Text = "No";
            this.labelBlue.Click += new System.EventHandler(this.LabelBlue_Click);
            // 
            // labelYellow
            // 
            this.labelYellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYellow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelYellow.Location = new System.Drawing.Point(128, 341);
            this.labelYellow.Name = "labelYellow";
            this.labelYellow.Size = new System.Drawing.Size(335, 37);
            this.labelYellow.TabIndex = 3;
            // 
            // labelInstructions
            // 
            this.labelInstructions.AutoSize = true;
            this.labelInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstructions.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelInstructions.Location = new System.Drawing.Point(13, 110);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(100, 72);
            this.labelInstructions.TabIndex = 7;
            this.labelInstructions.Text = "M = Red \r\nB = Blue\r\nC = Yellow\r\n";
            // 
            // yellowButton
            // 
            this.yellowButton.Image = global::Haunted_House_Adventure_Game.Properties.Resources.yellow_50x50;
            this.yellowButton.Location = new System.Drawing.Point(35, 341);
            this.yellowButton.Name = "yellowButton";
            this.yellowButton.Size = new System.Drawing.Size(77, 54);
            this.yellowButton.TabIndex = 6;
            // 
            // blueButton
            // 
            this.blueButton.Image = global::Haunted_House_Adventure_Game.Properties.Resources.blue_50x50;
            this.blueButton.Location = new System.Drawing.Point(25, 286);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(100, 55);
            this.blueButton.TabIndex = 5;
            // 
            // redButton
            // 
            this.redButton.Image = global::Haunted_House_Adventure_Game.Properties.Resources.red_50x50;
            this.redButton.Location = new System.Drawing.Point(25, 232);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(100, 54);
            this.redButton.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Haunted_House_Adventure_Game.Properties.Resources.haunted_house_4_by_fairiegoodmother_d5d3x91;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(486, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 312);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelInstructions);
            this.Controls.Add(this.yellowButton);
            this.Controls.Add(this.blueButton);
            this.Controls.Add(this.redButton);
            this.Controls.Add(this.labelYellow);
            this.Controls.Add(this.labelBlue);
            this.Controls.Add(this.labelRed);
            this.Controls.Add(this.labelMessage);
            this.Name = "Form1";
            this.Text = "Haunted House";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label labelRed;
        private System.Windows.Forms.Label labelBlue;
        private System.Windows.Forms.Label labelYellow;
        private System.Windows.Forms.Label redButton;
        private System.Windows.Forms.Label blueButton;
        private System.Windows.Forms.Label yellowButton;
        private System.Windows.Forms.Label labelInstructions;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

