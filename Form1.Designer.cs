namespace Rock_Paper_Scissor_Game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RockButton = new System.Windows.Forms.Button();
            this.PaperButton = new System.Windows.Forms.Button();
            this.ScissorsButton = new System.Windows.Forms.Button();
            this.ComputerPic = new System.Windows.Forms.PictureBox();
            this.UserPic = new System.Windows.Forms.PictureBox();
            this.labelCompChoice = new System.Windows.Forms.Label();
            this.labelUserChoice = new System.Windows.Forms.Label();
            this.labelPlayerResult = new System.Windows.Forms.Label();
            this.labelCompResult = new System.Windows.Forms.Label();
            this.FinalResultLable = new System.Windows.Forms.Label();
            this.EnterNameLabel = new System.Windows.Forms.Label();
            this.RestartButton = new System.Windows.Forms.Button();
            this.UserName = new System.Windows.Forms.TextBox();
            this.HighscoresLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPic)).BeginInit();
            this.SuspendLayout();
            // 
            // RockButton
            // 
            this.RockButton.Location = new System.Drawing.Point(12, 304);
            this.RockButton.Name = "RockButton";
            this.RockButton.Size = new System.Drawing.Size(75, 23);
            this.RockButton.TabIndex = 0;
            this.RockButton.Text = "Rock";
            this.RockButton.UseVisualStyleBackColor = true;
            this.RockButton.Click += new System.EventHandler(this.RockButton_Click);
            // 
            // PaperButton
            // 
            this.PaperButton.Location = new System.Drawing.Point(153, 304);
            this.PaperButton.Name = "PaperButton";
            this.PaperButton.Size = new System.Drawing.Size(75, 23);
            this.PaperButton.TabIndex = 1;
            this.PaperButton.Text = "Paper";
            this.PaperButton.UseVisualStyleBackColor = true;
            this.PaperButton.Click += new System.EventHandler(this.PaperButton_Click);
            // 
            // ScissorsButton
            // 
            this.ScissorsButton.Location = new System.Drawing.Point(284, 304);
            this.ScissorsButton.Name = "ScissorsButton";
            this.ScissorsButton.Size = new System.Drawing.Size(75, 23);
            this.ScissorsButton.TabIndex = 2;
            this.ScissorsButton.Text = "Scissors";
            this.ScissorsButton.UseVisualStyleBackColor = true;
            this.ScissorsButton.Click += new System.EventHandler(this.ScissorsButton_Click);
            // 
            // ComputerPic
            // 
            this.ComputerPic.Location = new System.Drawing.Point(153, 51);
            this.ComputerPic.Name = "ComputerPic";
            this.ComputerPic.Size = new System.Drawing.Size(143, 94);
            this.ComputerPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ComputerPic.TabIndex = 3;
            this.ComputerPic.TabStop = false;
            this.ComputerPic.SizeModeChanged += new System.EventHandler(this.RockButton_Click);
            // 
            // UserPic
            // 
            this.UserPic.Location = new System.Drawing.Point(153, 191);
            this.UserPic.Name = "UserPic";
            this.UserPic.Size = new System.Drawing.Size(143, 93);
            this.UserPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserPic.TabIndex = 4;
            this.UserPic.TabStop = false;
            // 
            // labelCompChoice
            // 
            this.labelCompChoice.AutoSize = true;
            this.labelCompChoice.Location = new System.Drawing.Point(174, 33);
            this.labelCompChoice.Name = "labelCompChoice";
            this.labelCompChoice.Size = new System.Drawing.Size(101, 15);
            this.labelCompChoice.TabIndex = 5;
            this.labelCompChoice.Text = "Computer Choice";
            // 
            // labelUserChoice
            // 
            this.labelUserChoice.AutoSize = true;
            this.labelUserChoice.Location = new System.Drawing.Point(186, 173);
            this.labelUserChoice.Name = "labelUserChoice";
            this.labelUserChoice.Size = new System.Drawing.Size(70, 15);
            this.labelUserChoice.TabIndex = 6;
            this.labelUserChoice.Text = "User Choice";
            // 
            // labelPlayerResult
            // 
            this.labelPlayerResult.AutoSize = true;
            this.labelPlayerResult.Location = new System.Drawing.Point(12, 230);
            this.labelPlayerResult.Name = "labelPlayerResult";
            this.labelPlayerResult.Size = new System.Drawing.Size(74, 15);
            this.labelPlayerResult.TabIndex = 7;
            this.labelPlayerResult.Text = "Player Result";
            // 
            // labelCompResult
            // 
            this.labelCompResult.AutoSize = true;
            this.labelCompResult.Location = new System.Drawing.Point(12, 91);
            this.labelCompResult.Name = "labelCompResult";
            this.labelCompResult.Size = new System.Drawing.Size(96, 15);
            this.labelCompResult.TabIndex = 8;
            this.labelCompResult.Text = "Computer Result";
            // 
            // FinalResultLable
            // 
            this.FinalResultLable.AutoSize = true;
            this.FinalResultLable.Location = new System.Drawing.Point(174, 363);
            this.FinalResultLable.Name = "FinalResultLable";
            this.FinalResultLable.Size = new System.Drawing.Size(67, 15);
            this.FinalResultLable.TabIndex = 9;
            this.FinalResultLable.Text = "Final Result";
            // 
            // EnterNameLabel
            // 
            this.EnterNameLabel.AutoSize = true;
            this.EnterNameLabel.Location = new System.Drawing.Point(418, 56);
            this.EnterNameLabel.Name = "EnterNameLabel";
            this.EnterNameLabel.Size = new System.Drawing.Size(96, 15);
            this.EnterNameLabel.TabIndex = 10;
            this.EnterNameLabel.Text = "Enter Your Name";
            // 
            // RestartButton
            // 
            this.RestartButton.Location = new System.Drawing.Point(940, 399);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(75, 23);
            this.RestartButton.TabIndex = 12;
            this.RestartButton.Text = "Restart";
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(414, 74);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(100, 23);
            this.UserName.TabIndex = 13;
            this.UserName.TextChanged += new System.EventHandler(this.UserName_TextChanged);
            // 
            // HighscoresLabel
            // 
            this.HighscoresLabel.AutoSize = true;
            this.HighscoresLabel.Location = new System.Drawing.Point(714, 173);
            this.HighscoresLabel.Name = "HighscoresLabel";
            this.HighscoresLabel.Size = new System.Drawing.Size(62, 15);
            this.HighscoresLabel.TabIndex = 14;
            this.HighscoresLabel.Text = "HighScore";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(598, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 30);
            this.label1.TabIndex = 15;
            this.label1.Text = "Set Of Rules\r\nplayer plays 10 games. whoever score more will be the winner.\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HighscoresLabel);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.EnterNameLabel);
            this.Controls.Add(this.FinalResultLable);
            this.Controls.Add(this.labelCompResult);
            this.Controls.Add(this.labelPlayerResult);
            this.Controls.Add(this.labelUserChoice);
            this.Controls.Add(this.labelCompChoice);
            this.Controls.Add(this.UserPic);
            this.Controls.Add(this.ComputerPic);
            this.Controls.Add(this.ScissorsButton);
            this.Controls.Add(this.PaperButton);
            this.Controls.Add(this.RockButton);
            this.Name = "Form1";
            this.Text = "Rock Paper Scissor Game";
            ((System.ComponentModel.ISupportInitialize)(this.ComputerPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RockButton;
        private System.Windows.Forms.Button PaperButton;
        private System.Windows.Forms.Button ScissorsButton;
        private System.Windows.Forms.PictureBox ComputerPic;
        private System.Windows.Forms.PictureBox UserPic;
        private System.Windows.Forms.Label labelCompChoice;
        private System.Windows.Forms.Label labelUserChoice;
        private System.Windows.Forms.Label labelPlayerResult;
        private System.Windows.Forms.Label labelCompResult;
        private System.Windows.Forms.Label FinalResultLable;
        private System.Windows.Forms.Label EnterNameLabel;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Label HighscoresLabel;
        private System.Windows.Forms.Label label1;
    }
}
