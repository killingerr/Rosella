namespace RPS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.RockButton = new System.Windows.Forms.Button();
            this.PaperButton = new System.Windows.Forms.Button();
            this.ScissorsButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.playerLabel = new System.Windows.Forms.Label();
            this.npcLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.roundsWonN = new System.Windows.Forms.Label();
            this.roundsWonP = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // RockButton
            // 
            this.RockButton.Image = ((System.Drawing.Image)(resources.GetObject("RockButton.Image")));
            this.RockButton.Location = new System.Drawing.Point(246, 348);
            this.RockButton.Name = "RockButton";
            this.RockButton.Size = new System.Drawing.Size(100, 100);
            this.RockButton.TabIndex = 0;
            this.RockButton.UseVisualStyleBackColor = true;
            this.RockButton.Click += new System.EventHandler(this.RockButton_Click);
            // 
            // PaperButton
            // 
            this.PaperButton.Image = ((System.Drawing.Image)(resources.GetObject("PaperButton.Image")));
            this.PaperButton.Location = new System.Drawing.Point(383, 348);
            this.PaperButton.Name = "PaperButton";
            this.PaperButton.Size = new System.Drawing.Size(100, 100);
            this.PaperButton.TabIndex = 1;
            this.PaperButton.UseVisualStyleBackColor = true;
            this.PaperButton.Click += new System.EventHandler(this.PaperButton_Click);
            // 
            // ScissorsButton
            // 
            this.ScissorsButton.Image = ((System.Drawing.Image)(resources.GetObject("ScissorsButton.Image")));
            this.ScissorsButton.Location = new System.Drawing.Point(523, 348);
            this.ScissorsButton.Name = "ScissorsButton";
            this.ScissorsButton.Size = new System.Drawing.Size(100, 100);
            this.ScissorsButton.TabIndex = 2;
            this.ScissorsButton.UseVisualStyleBackColor = true;
            this.ScissorsButton.Click += new System.EventHandler(this.ScissorsButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("SonicCutThru Hv BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(271, 526);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 65);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("SonicCutThru Hv BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.Location = new System.Drawing.Point(396, 526);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 65);
            this.ResetButton.TabIndex = 4;
            this.ResetButton.Text = "reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Font = new System.Drawing.Font("SonicCutThru Hv BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitButton.Location = new System.Drawing.Point(523, 526);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(75, 65);
            this.QuitButton.TabIndex = 5;
            this.QuitButton.Text = "quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Location = new System.Drawing.Point(246, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(377, 295);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SonicCutThru Hv BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 34);
            this.label1.TabIndex = 8;
            this.label1.Text = "Player Wins";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SonicCutThru Hv BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(629, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 34);
            this.label2.TabIndex = 9;
            this.label2.Text = "A.I. Wins";
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Font = new System.Drawing.Font("SonicCutThru Hv BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerLabel.Location = new System.Drawing.Point(147, 177);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(0, 14);
            this.playerLabel.TabIndex = 10;
            // 
            // npcLabel
            // 
            this.npcLabel.AutoSize = true;
            this.npcLabel.Font = new System.Drawing.Font("SonicCutThru Hv BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npcLabel.Location = new System.Drawing.Point(683, 177);
            this.npcLabel.Name = "npcLabel";
            this.npcLabel.Size = new System.Drawing.Size(0, 14);
            this.npcLabel.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SonicCutThru Hv BT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(629, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Rounds Won";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("SonicCutThru Hv BT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(91, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Rounds Won";
            // 
            // roundsWonN
            // 
            this.roundsWonN.AutoSize = true;
            this.roundsWonN.Font = new System.Drawing.Font("SonicCutThru Hv BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundsWonN.Location = new System.Drawing.Point(683, 49);
            this.roundsWonN.Name = "roundsWonN";
            this.roundsWonN.Size = new System.Drawing.Size(0, 14);
            this.roundsWonN.TabIndex = 14;
            // 
            // roundsWonP
            // 
            this.roundsWonP.AutoSize = true;
            this.roundsWonP.Font = new System.Drawing.Font("SonicCutThru Hv BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundsWonP.Location = new System.Drawing.Point(147, 49);
            this.roundsWonP.Name = "roundsWonP";
            this.roundsWonP.Size = new System.Drawing.Size(0, 14);
            this.roundsWonP.TabIndex = 15;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "First to 3",
            "First to 5",
            "First to 7",
            "First to 9"});
            this.comboBox1.Location = new System.Drawing.Point(28, 504);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 631);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.roundsWonP);
            this.Controls.Add(this.roundsWonN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.npcLabel);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ScissorsButton);
            this.Controls.Add(this.PaperButton);
            this.Controls.Add(this.RockButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RockButton;
        private System.Windows.Forms.Button PaperButton;
        private System.Windows.Forms.Button ScissorsButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Label npcLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label roundsWonN;
        private System.Windows.Forms.Label roundsWonP;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

