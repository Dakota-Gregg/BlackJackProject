namespace WindowsFormsApp2
{
    partial class FormPlayGame
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonResume = new System.Windows.Forms.Button();
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.buttonProfileInfo = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.buttonRules = new System.Windows.Forms.Button();
            this.labelWin = new System.Windows.Forms.Label();
            this.labelLose = new System.Windows.Forms.Label();
            this.labelMoney = new System.Windows.Forms.Label();
            this.labelWinCount = new System.Windows.Forms.Label();
            this.labelLoseCount = new System.Windows.Forms.Label();
            this.labelMoneyAmount = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.buttonNewProfile = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(271, 52);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(210, 31);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Blackjack Game";
            // 
            // buttonResume
            // 
            this.buttonResume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResume.Location = new System.Drawing.Point(309, 121);
            this.buttonResume.Name = "buttonResume";
            this.buttonResume.Size = new System.Drawing.Size(127, 37);
            this.buttonResume.TabIndex = 1;
            this.buttonResume.Text = "Resume Game";
            this.buttonResume.UseVisualStyleBackColor = true;
            this.buttonResume.Click += new System.EventHandler(this.buttonResume_Click);
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewGame.Location = new System.Drawing.Point(309, 176);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(127, 37);
            this.buttonNewGame.TabIndex = 2;
            this.buttonNewGame.Text = "New Game";
            this.buttonNewGame.UseVisualStyleBackColor = true;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // buttonProfileInfo
            // 
            this.buttonProfileInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProfileInfo.Location = new System.Drawing.Point(309, 293);
            this.buttonProfileInfo.Name = "buttonProfileInfo";
            this.buttonProfileInfo.Size = new System.Drawing.Size(127, 37);
            this.buttonProfileInfo.TabIndex = 3;
            this.buttonProfileInfo.Text = "Profile";
            this.buttonProfileInfo.UseVisualStyleBackColor = true;
            this.buttonProfileInfo.Click += new System.EventHandler(this.buttonProfileInfo_Click);
            // 
            // buttonQuit
            // 
            this.buttonQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuit.Location = new System.Drawing.Point(309, 354);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(127, 37);
            this.buttonQuit.TabIndex = 4;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // buttonRules
            // 
            this.buttonRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRules.Location = new System.Drawing.Point(309, 236);
            this.buttonRules.Name = "buttonRules";
            this.buttonRules.Size = new System.Drawing.Size(127, 37);
            this.buttonRules.TabIndex = 5;
            this.buttonRules.Text = "Rule Book";
            this.buttonRules.UseVisualStyleBackColor = true;
            this.buttonRules.Click += new System.EventHandler(this.buttonRules_Click);
            // 
            // labelWin
            // 
            this.labelWin.AutoSize = true;
            this.labelWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWin.Location = new System.Drawing.Point(500, 185);
            this.labelWin.Name = "labelWin";
            this.labelWin.Size = new System.Drawing.Size(44, 20);
            this.labelWin.TabIndex = 6;
            this.labelWin.Text = "Wins";
            // 
            // labelLose
            // 
            this.labelLose.AutoSize = true;
            this.labelLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLose.Location = new System.Drawing.Point(575, 185);
            this.labelLose.Name = "labelLose";
            this.labelLose.Size = new System.Drawing.Size(52, 20);
            this.labelLose.TabIndex = 7;
            this.labelLose.Text = "Loses";
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMoney.Location = new System.Drawing.Point(657, 185);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(56, 20);
            this.labelMoney.TabIndex = 8;
            this.labelMoney.Text = "Money";
            // 
            // labelWinCount
            // 
            this.labelWinCount.AutoSize = true;
            this.labelWinCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWinCount.Location = new System.Drawing.Point(509, 215);
            this.labelWinCount.Name = "labelWinCount";
            this.labelWinCount.Size = new System.Drawing.Size(18, 20);
            this.labelWinCount.TabIndex = 9;
            this.labelWinCount.Text = "0";
            // 
            // labelLoseCount
            // 
            this.labelLoseCount.AutoSize = true;
            this.labelLoseCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoseCount.Location = new System.Drawing.Point(591, 215);
            this.labelLoseCount.Name = "labelLoseCount";
            this.labelLoseCount.Size = new System.Drawing.Size(18, 20);
            this.labelLoseCount.TabIndex = 10;
            this.labelLoseCount.Text = "0";
            // 
            // labelMoneyAmount
            // 
            this.labelMoneyAmount.AutoSize = true;
            this.labelMoneyAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMoneyAmount.Location = new System.Drawing.Point(677, 215);
            this.labelMoneyAmount.Name = "labelMoneyAmount";
            this.labelMoneyAmount.Size = new System.Drawing.Size(18, 20);
            this.labelMoneyAmount.TabIndex = 11;
            this.labelMoneyAmount.Text = "0";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelUser.Location = new System.Drawing.Point(575, 146);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(100, 24);
            this.labelUser.TabIndex = 12;
            this.labelUser.Text = "UserName";
            // 
            // buttonNewProfile
            // 
            this.buttonNewProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewProfile.Location = new System.Drawing.Point(54, 263);
            this.buttonNewProfile.Name = "buttonNewProfile";
            this.buttonNewProfile.Size = new System.Drawing.Size(127, 37);
            this.buttonNewProfile.TabIndex = 13;
            this.buttonNewProfile.Text = "New Profile";
            this.buttonNewProfile.UseVisualStyleBackColor = true;
            this.buttonNewProfile.Click += new System.EventHandler(this.buttonNewProfile_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(54, 198);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(127, 37);
            this.buttonLogin.TabIndex = 14;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // FormPlayGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonNewProfile);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.labelMoneyAmount);
            this.Controls.Add(this.labelLoseCount);
            this.Controls.Add(this.labelWinCount);
            this.Controls.Add(this.labelMoney);
            this.Controls.Add(this.labelLose);
            this.Controls.Add(this.labelWin);
            this.Controls.Add(this.buttonRules);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.buttonProfileInfo);
            this.Controls.Add(this.buttonNewGame);
            this.Controls.Add(this.buttonResume);
            this.Controls.Add(this.labelTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPlayGame";
            this.Text = "Blackjack Game";
            this.Load += new System.EventHandler(this.FormPlayGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonResume;
        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.Button buttonProfileInfo;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.Button buttonRules;
        private System.Windows.Forms.Label labelWin;
        private System.Windows.Forms.Label labelLose;
        private System.Windows.Forms.Label labelMoney;
        private System.Windows.Forms.Label labelWinCount;
        private System.Windows.Forms.Label labelLoseCount;
        private System.Windows.Forms.Label labelMoneyAmount;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Button buttonNewProfile;
        private System.Windows.Forms.Button buttonLogin;
    }
}