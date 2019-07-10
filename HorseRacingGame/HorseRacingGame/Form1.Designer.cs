namespace HorseRacingGame
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
            this.bettingplace = new System.Windows.Forms.GroupBox();
            this.joeRadioButton = new System.Windows.Forms.RadioButton();
            this.bobRadioButton = new System.Windows.Forms.RadioButton();
            this.aiRadioButton = new System.Windows.Forms.RadioButton();
            this.aiLabel = new System.Windows.Forms.Label();
            this.bobLabel = new System.Windows.Forms.Label();
            this.joeLabel = new System.Windows.Forms.Label();
            this.numericUpDownMember = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBets = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MinimumBet = new System.Windows.Forms.Label();
            this.btnBets = new System.Windows.Forms.Button();
            this.btnRace = new System.Windows.Forms.Button();
            this.horse4 = new System.Windows.Forms.PictureBox();
            this.horse3 = new System.Windows.Forms.PictureBox();
            this.horse2 = new System.Windows.Forms.PictureBox();
            this.horse1 = new System.Windows.Forms.PictureBox();
            this.horseTrack = new System.Windows.Forms.PictureBox();
            this.bettingplace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horse4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horse3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horse2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horse1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horseTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // bettingplace
            // 
            this.bettingplace.BackColor = System.Drawing.Color.DarkOrange;
            this.bettingplace.Controls.Add(this.btnRace);
            this.bettingplace.Controls.Add(this.btnBets);
            this.bettingplace.Controls.Add(this.MinimumBet);
            this.bettingplace.Controls.Add(this.numericUpDownMember);
            this.bettingplace.Controls.Add(this.numericUpDownBets);
            this.bettingplace.Controls.Add(this.label2);
            this.bettingplace.Controls.Add(this.label1);
            this.bettingplace.Controls.Add(this.aiLabel);
            this.bettingplace.Controls.Add(this.bobLabel);
            this.bettingplace.Controls.Add(this.joeLabel);
            this.bettingplace.Controls.Add(this.aiRadioButton);
            this.bettingplace.Controls.Add(this.bobRadioButton);
            this.bettingplace.Controls.Add(this.joeRadioButton);
            this.bettingplace.Location = new System.Drawing.Point(12, 428);
            this.bettingplace.Name = "bettingplace";
            this.bettingplace.Size = new System.Drawing.Size(388, 171);
            this.bettingplace.TabIndex = 5;
            this.bettingplace.TabStop = false;
            this.bettingplace.Text = "Betting Place";
            // 
            // joeRadioButton
            // 
            this.joeRadioButton.AutoSize = true;
            this.joeRadioButton.Location = new System.Drawing.Point(17, 19);
            this.joeRadioButton.Name = "joeRadioButton";
            this.joeRadioButton.Size = new System.Drawing.Size(42, 17);
            this.joeRadioButton.TabIndex = 0;
            this.joeRadioButton.TabStop = true;
            this.joeRadioButton.Text = "Joe";
            this.joeRadioButton.UseVisualStyleBackColor = true;
            // 
            // bobRadioButton
            // 
            this.bobRadioButton.AutoSize = true;
            this.bobRadioButton.Location = new System.Drawing.Point(17, 52);
            this.bobRadioButton.Name = "bobRadioButton";
            this.bobRadioButton.Size = new System.Drawing.Size(44, 17);
            this.bobRadioButton.TabIndex = 1;
            this.bobRadioButton.TabStop = true;
            this.bobRadioButton.Text = "Bob";
            this.bobRadioButton.UseVisualStyleBackColor = true;
            // 
            // aiRadioButton
            // 
            this.aiRadioButton.AutoSize = true;
            this.aiRadioButton.Location = new System.Drawing.Point(17, 89);
            this.aiRadioButton.Name = "aiRadioButton";
            this.aiRadioButton.Size = new System.Drawing.Size(35, 17);
            this.aiRadioButton.TabIndex = 2;
            this.aiRadioButton.TabStop = true;
            this.aiRadioButton.Text = "AI";
            this.aiRadioButton.UseVisualStyleBackColor = true;
            // 
            // aiLabel
            // 
            this.aiLabel.AutoSize = true;
            this.aiLabel.BackColor = System.Drawing.Color.White;
            this.aiLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aiLabel.Location = new System.Drawing.Point(124, 85);
            this.aiLabel.Name = "aiLabel";
            this.aiLabel.Size = new System.Drawing.Size(103, 15);
            this.aiLabel.TabIndex = 28;
            this.aiLabel.Text = "AI hasn\'t placed bet";
            // 
            // bobLabel
            // 
            this.bobLabel.AutoSize = true;
            this.bobLabel.BackColor = System.Drawing.Color.White;
            this.bobLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bobLabel.Location = new System.Drawing.Point(124, 51);
            this.bobLabel.Name = "bobLabel";
            this.bobLabel.Size = new System.Drawing.Size(112, 15);
            this.bobLabel.TabIndex = 27;
            this.bobLabel.Text = "Bob hasn\'t placed bet";
            // 
            // joeLabel
            // 
            this.joeLabel.AutoSize = true;
            this.joeLabel.BackColor = System.Drawing.Color.White;
            this.joeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.joeLabel.Location = new System.Drawing.Point(124, 16);
            this.joeLabel.Name = "joeLabel";
            this.joeLabel.Size = new System.Drawing.Size(110, 15);
            this.joeLabel.TabIndex = 26;
            this.joeLabel.Text = "Joe hasn\'t placed bet";
            // 
            // numericUpDownMember
            // 
            this.numericUpDownMember.Location = new System.Drawing.Point(338, 49);
            this.numericUpDownMember.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownMember.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMember.Name = "numericUpDownMember";
            this.numericUpDownMember.Size = new System.Drawing.Size(44, 20);
            this.numericUpDownMember.TabIndex = 32;
            this.numericUpDownMember.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownBets
            // 
            this.numericUpDownBets.Location = new System.Drawing.Point(338, 19);
            this.numericUpDownBets.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownBets.Name = "numericUpDownBets";
            this.numericUpDownBets.Size = new System.Drawing.Size(44, 20);
            this.numericUpDownBets.TabIndex = 31;
            this.numericUpDownBets.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = " #";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "$";
            // 
            // MinimumBet
            // 
            this.MinimumBet.AutoSize = true;
            this.MinimumBet.Location = new System.Drawing.Point(234, 109);
            this.MinimumBet.Name = "MinimumBet";
            this.MinimumBet.Size = new System.Drawing.Size(67, 13);
            this.MinimumBet.TabIndex = 33;
            this.MinimumBet.Text = "Minimum Bet";
            // 
            // btnBets
            // 
            this.btnBets.BackColor = System.Drawing.Color.Sienna;
            this.btnBets.Location = new System.Drawing.Point(283, 76);
            this.btnBets.Name = "btnBets";
            this.btnBets.Size = new System.Drawing.Size(99, 30);
            this.btnBets.TabIndex = 34;
            this.btnBets.Text = "Place Bet";
            this.btnBets.UseVisualStyleBackColor = false;
            this.btnBets.Click += new System.EventHandler(this.btnBets_Click);
            // 
            // btnRace
            // 
            this.btnRace.BackColor = System.Drawing.Color.Sienna;
            this.btnRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRace.Location = new System.Drawing.Point(65, 133);
            this.btnRace.Name = "btnRace";
            this.btnRace.Size = new System.Drawing.Size(252, 32);
            this.btnRace.TabIndex = 35;
            this.btnRace.Text = "Race!";
            this.btnRace.UseVisualStyleBackColor = false;
            this.btnRace.Click += new System.EventHandler(this.btnRace_Click);
            // 
            // horse4
            // 
            this.horse4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.horse4.Image = global::HorseRacingGame.Properties.Resources.h41;
            this.horse4.Location = new System.Drawing.Point(313, 12);
            this.horse4.Name = "horse4";
            this.horse4.Size = new System.Drawing.Size(40, 101);
            this.horse4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.horse4.TabIndex = 4;
            this.horse4.TabStop = false;
            // 
            // horse3
            // 
            this.horse3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.horse3.Image = global::HorseRacingGame.Properties.Resources.h31;
            this.horse3.Location = new System.Drawing.Point(226, 12);
            this.horse3.Name = "horse3";
            this.horse3.Size = new System.Drawing.Size(40, 101);
            this.horse3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.horse3.TabIndex = 3;
            this.horse3.TabStop = false;
            // 
            // horse2
            // 
            this.horse2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.horse2.Image = global::HorseRacingGame.Properties.Resources.h21;
            this.horse2.Location = new System.Drawing.Point(136, 12);
            this.horse2.Name = "horse2";
            this.horse2.Size = new System.Drawing.Size(40, 101);
            this.horse2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.horse2.TabIndex = 2;
            this.horse2.TabStop = false;
            // 
            // horse1
            // 
            this.horse1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.horse1.Image = global::HorseRacingGame.Properties.Resources.h11;
            this.horse1.Location = new System.Drawing.Point(58, 12);
            this.horse1.Name = "horse1";
            this.horse1.Size = new System.Drawing.Size(40, 101);
            this.horse1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.horse1.TabIndex = 1;
            this.horse1.TabStop = false;
            // 
            // horseTrack
            // 
            this.horseTrack.Image = global::HorseRacingGame.Properties.Resources.trk;
            this.horseTrack.Location = new System.Drawing.Point(0, 0);
            this.horseTrack.Name = "horseTrack";
            this.horseTrack.Size = new System.Drawing.Size(411, 422);
            this.horseTrack.TabIndex = 0;
            this.horseTrack.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 605);
            this.Controls.Add(this.bettingplace);
            this.Controls.Add(this.horse4);
            this.Controls.Add(this.horse3);
            this.Controls.Add(this.horse2);
            this.Controls.Add(this.horse1);
            this.Controls.Add(this.horseTrack);
            this.Name = "Form1";
            this.Text = "Gurpinder Singh";
            this.bettingplace.ResumeLayout(false);
            this.bettingplace.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horse4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horse3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horse2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horse1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horseTrack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox horseTrack;
        private System.Windows.Forms.PictureBox horse1;
        private System.Windows.Forms.PictureBox horse2;
        private System.Windows.Forms.PictureBox horse3;
        private System.Windows.Forms.PictureBox horse4;
        private System.Windows.Forms.GroupBox bettingplace;
        private System.Windows.Forms.Label MinimumBet;
        private System.Windows.Forms.NumericUpDown numericUpDownMember;
        private System.Windows.Forms.NumericUpDown numericUpDownBets;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label aiLabel;
        private System.Windows.Forms.Label bobLabel;
        private System.Windows.Forms.Label joeLabel;
        private System.Windows.Forms.RadioButton aiRadioButton;
        private System.Windows.Forms.RadioButton bobRadioButton;
        private System.Windows.Forms.RadioButton joeRadioButton;
        private System.Windows.Forms.Button btnBets;
        private System.Windows.Forms.Button btnRace;
    }
}

