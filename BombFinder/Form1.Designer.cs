namespace BombFinder
{
    partial class BombFinder
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
            this.easyRadio = new System.Windows.Forms.RadioButton();
            this.moderateRadio = new System.Windows.Forms.RadioButton();
            this.hardRadio = new System.Windows.Forms.RadioButton();
            this.difficultyGroupBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.customRadio = new System.Windows.Forms.RadioButton();
            this.slightlyHarderRadio = new System.Windows.Forms.RadioButton();
            this.startBtn = new System.Windows.Forms.Button();
            this.customRulesGroupBox = new System.Windows.Forms.GroupBox();
            this.safeCheckBox = new System.Windows.Forms.CheckBox();
            this.bombsLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bombsTrackBar = new System.Windows.Forms.TrackBar();
            this.widthTrackBar = new System.Windows.Forms.TrackBar();
            this.heightTrackBar = new System.Windows.Forms.TrackBar();
            this.gameLogo = new System.Windows.Forms.Label();
            this.difficultyGroupBox.SuspendLayout();
            this.customRulesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bombsTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // easyRadio
            // 
            this.easyRadio.AutoSize = true;
            this.easyRadio.Location = new System.Drawing.Point(6, 24);
            this.easyRadio.Name = "easyRadio";
            this.easyRadio.Size = new System.Drawing.Size(48, 17);
            this.easyRadio.TabIndex = 0;
            this.easyRadio.TabStop = true;
            this.easyRadio.Text = "Easy";
            this.easyRadio.UseVisualStyleBackColor = true;
            // 
            // moderateRadio
            // 
            this.moderateRadio.AutoSize = true;
            this.moderateRadio.Location = new System.Drawing.Point(6, 47);
            this.moderateRadio.Name = "moderateRadio";
            this.moderateRadio.Size = new System.Drawing.Size(70, 17);
            this.moderateRadio.TabIndex = 1;
            this.moderateRadio.TabStop = true;
            this.moderateRadio.Text = "Moderate";
            this.moderateRadio.UseVisualStyleBackColor = true;
            // 
            // hardRadio
            // 
            this.hardRadio.AutoSize = true;
            this.hardRadio.Location = new System.Drawing.Point(6, 70);
            this.hardRadio.Name = "hardRadio";
            this.hardRadio.Size = new System.Drawing.Size(48, 17);
            this.hardRadio.TabIndex = 2;
            this.hardRadio.TabStop = true;
            this.hardRadio.Text = "Hard";
            this.hardRadio.UseVisualStyleBackColor = true;
            // 
            // difficultyGroupBox
            // 
            this.difficultyGroupBox.Controls.Add(this.label5);
            this.difficultyGroupBox.Controls.Add(this.label4);
            this.difficultyGroupBox.Controls.Add(this.label3);
            this.difficultyGroupBox.Controls.Add(this.label2);
            this.difficultyGroupBox.Controls.Add(this.label1);
            this.difficultyGroupBox.Controls.Add(this.customRadio);
            this.difficultyGroupBox.Controls.Add(this.slightlyHarderRadio);
            this.difficultyGroupBox.Controls.Add(this.moderateRadio);
            this.difficultyGroupBox.Controls.Add(this.hardRadio);
            this.difficultyGroupBox.Controls.Add(this.easyRadio);
            this.difficultyGroupBox.Location = new System.Drawing.Point(18, 42);
            this.difficultyGroupBox.Name = "difficultyGroupBox";
            this.difficultyGroupBox.Size = new System.Drawing.Size(199, 140);
            this.difficultyGroupBox.TabIndex = 3;
            this.difficultyGroupBox.TabStop = false;
            this.difficultyGroupBox.Text = "Difficulty";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "30x30 899 Bombs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "30x16 100 Bombs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "16x16 40 Bombs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "8x8 10 Bombs";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // customRadio
            // 
            this.customRadio.AutoSize = true;
            this.customRadio.Location = new System.Drawing.Point(6, 116);
            this.customRadio.Name = "customRadio";
            this.customRadio.Size = new System.Drawing.Size(60, 17);
            this.customRadio.TabIndex = 4;
            this.customRadio.TabStop = true;
            this.customRadio.Text = "Custom";
            this.customRadio.UseVisualStyleBackColor = true;
            this.customRadio.CheckedChanged += new System.EventHandler(this.customRadio_CheckedChanged);
            // 
            // slightlyHarderRadio
            // 
            this.slightlyHarderRadio.AutoSize = true;
            this.slightlyHarderRadio.Location = new System.Drawing.Point(6, 93);
            this.slightlyHarderRadio.Name = "slightlyHarderRadio";
            this.slightlyHarderRadio.Size = new System.Drawing.Size(93, 17);
            this.slightlyHarderRadio.TabIndex = 3;
            this.slightlyHarderRadio.TabStop = true;
            this.slightlyHarderRadio.Text = "Slightly Harder";
            this.slightlyHarderRadio.UseVisualStyleBackColor = true;
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.startBtn.Location = new System.Drawing.Point(75, 239);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 4;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // customRulesGroupBox
            // 
            this.customRulesGroupBox.Controls.Add(this.safeCheckBox);
            this.customRulesGroupBox.Controls.Add(this.bombsLabel);
            this.customRulesGroupBox.Controls.Add(this.widthLabel);
            this.customRulesGroupBox.Controls.Add(this.heightLabel);
            this.customRulesGroupBox.Controls.Add(this.label8);
            this.customRulesGroupBox.Controls.Add(this.label7);
            this.customRulesGroupBox.Controls.Add(this.label6);
            this.customRulesGroupBox.Controls.Add(this.bombsTrackBar);
            this.customRulesGroupBox.Controls.Add(this.widthTrackBar);
            this.customRulesGroupBox.Controls.Add(this.heightTrackBar);
            this.customRulesGroupBox.Location = new System.Drawing.Point(236, 13);
            this.customRulesGroupBox.Name = "customRulesGroupBox";
            this.customRulesGroupBox.Size = new System.Drawing.Size(117, 249);
            this.customRulesGroupBox.TabIndex = 5;
            this.customRulesGroupBox.TabStop = false;
            this.customRulesGroupBox.Text = "Custom Rules";
            this.customRulesGroupBox.Visible = false;
            // 
            // safeCheckBox
            // 
            this.safeCheckBox.AutoSize = true;
            this.safeCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.safeCheckBox.Location = new System.Drawing.Point(9, 215);
            this.safeCheckBox.Name = "safeCheckBox";
            this.safeCheckBox.Size = new System.Drawing.Size(104, 17);
            this.safeCheckBox.TabIndex = 9;
            this.safeCheckBox.Text = "First Click is Safe";
            this.safeCheckBox.UseVisualStyleBackColor = true;
            // 
            // bombsLabel
            // 
            this.bombsLabel.AutoSize = true;
            this.bombsLabel.Location = new System.Drawing.Point(47, 147);
            this.bombsLabel.Name = "bombsLabel";
            this.bombsLabel.Size = new System.Drawing.Size(13, 13);
            this.bombsLabel.TabIndex = 8;
            this.bombsLabel.Text = "5";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(47, 85);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(13, 13);
            this.widthLabel.TabIndex = 7;
            this.widthLabel.Text = "8";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(47, 23);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(13, 13);
            this.heightLabel.TabIndex = 6;
            this.heightLabel.Text = "8";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Bombs: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Width:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Height: ";
            // 
            // bombsTrackBar
            // 
            this.bombsTrackBar.Location = new System.Drawing.Point(6, 163);
            this.bombsTrackBar.Maximum = 63;
            this.bombsTrackBar.Minimum = 5;
            this.bombsTrackBar.Name = "bombsTrackBar";
            this.bombsTrackBar.Size = new System.Drawing.Size(104, 45);
            this.bombsTrackBar.TabIndex = 2;
            this.bombsTrackBar.Value = 5;
            this.bombsTrackBar.Scroll += new System.EventHandler(this.bombsTrackBar_Scroll);
            // 
            // widthTrackBar
            // 
            this.widthTrackBar.Location = new System.Drawing.Point(6, 103);
            this.widthTrackBar.Maximum = 30;
            this.widthTrackBar.Minimum = 8;
            this.widthTrackBar.Name = "widthTrackBar";
            this.widthTrackBar.Size = new System.Drawing.Size(104, 45);
            this.widthTrackBar.TabIndex = 1;
            this.widthTrackBar.Value = 8;
            this.widthTrackBar.Scroll += new System.EventHandler(this.widthTrackBar_Scroll);
            // 
            // heightTrackBar
            // 
            this.heightTrackBar.Location = new System.Drawing.Point(6, 43);
            this.heightTrackBar.Maximum = 30;
            this.heightTrackBar.Minimum = 8;
            this.heightTrackBar.Name = "heightTrackBar";
            this.heightTrackBar.Size = new System.Drawing.Size(99, 45);
            this.heightTrackBar.TabIndex = 0;
            this.heightTrackBar.Value = 8;
            this.heightTrackBar.Scroll += new System.EventHandler(this.heightTrackBar_Scroll);
            // 
            // gameLogo
            // 
            this.gameLogo.AutoSize = true;
            this.gameLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameLogo.Location = new System.Drawing.Point(13, 9);
            this.gameLogo.Name = "gameLogo";
            this.gameLogo.Size = new System.Drawing.Size(137, 26);
            this.gameLogo.TabIndex = 6;
            this.gameLogo.Text = "Bomb Finder";
            // 
            // BombFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 274);
            this.Controls.Add(this.gameLogo);
            this.Controls.Add(this.customRulesGroupBox);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.difficultyGroupBox);
            this.Name = "BombFinder";
            this.Text = "Bomb Finder";
            this.difficultyGroupBox.ResumeLayout(false);
            this.difficultyGroupBox.PerformLayout();
            this.customRulesGroupBox.ResumeLayout(false);
            this.customRulesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bombsTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton easyRadio;
        private System.Windows.Forms.RadioButton moderateRadio;
        private System.Windows.Forms.RadioButton hardRadio;
        private System.Windows.Forms.GroupBox difficultyGroupBox;
        private System.Windows.Forms.RadioButton customRadio;
        private System.Windows.Forms.RadioButton slightlyHarderRadio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.GroupBox customRulesGroupBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label bombsLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar bombsTrackBar;
        private System.Windows.Forms.TrackBar widthTrackBar;
        private System.Windows.Forms.TrackBar heightTrackBar;
        private System.Windows.Forms.Label gameLogo;
        private System.Windows.Forms.CheckBox safeCheckBox;
    }
}

