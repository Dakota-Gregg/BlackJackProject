namespace WindowsFormsApp2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonHit = new System.Windows.Forms.Button();
            this.buttonStay = new System.Windows.Forms.Button();
            this.dealerHand = new System.Windows.Forms.ImageList(this.components);
            this.playerHand = new System.Windows.Forms.ImageList(this.components);
            this.boxD2 = new System.Windows.Forms.PictureBox();
            this.boxD1 = new System.Windows.Forms.PictureBox();
            this.boxD3 = new System.Windows.Forms.PictureBox();
            this.boxD4 = new System.Windows.Forms.PictureBox();
            this.boxD5 = new System.Windows.Forms.PictureBox();
            this.boxD6 = new System.Windows.Forms.PictureBox();
            this.boxD7 = new System.Windows.Forms.PictureBox();
            this.boxD8 = new System.Windows.Forms.PictureBox();
            this.boxP8 = new System.Windows.Forms.PictureBox();
            this.boxP7 = new System.Windows.Forms.PictureBox();
            this.boxP6 = new System.Windows.Forms.PictureBox();
            this.boxP5 = new System.Windows.Forms.PictureBox();
            this.boxP4 = new System.Windows.Forms.PictureBox();
            this.boxP3 = new System.Windows.Forms.PictureBox();
            this.boxP1 = new System.Windows.Forms.PictureBox();
            this.boxP2 = new System.Windows.Forms.PictureBox();
            this.labelPlayer = new System.Windows.Forms.Label();
            this.labelDealer = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.textBet = new System.Windows.Forms.TextBox();
            this.labelBetAmount = new System.Windows.Forms.Label();
            this.labelPlayerScore = new System.Windows.Forms.Label();
            this.labelDealerScore = new System.Windows.Forms.Label();
            this.buttonNewHand = new System.Windows.Forms.Button();
            this.buttonBet = new System.Windows.Forms.Button();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblPot = new System.Windows.Forms.Label();
            this.lblCurrentPot = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.boxD2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxD1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxD3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxD4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxD5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxD6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxD7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxD8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxP8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxP7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxP6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxP5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxP4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxP3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxP2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonHit
            // 
            this.buttonHit.Location = new System.Drawing.Point(212, 308);
            this.buttonHit.Name = "buttonHit";
            this.buttonHit.Size = new System.Drawing.Size(67, 32);
            this.buttonHit.TabIndex = 0;
            this.buttonHit.Text = "Hit";
            this.buttonHit.UseVisualStyleBackColor = true;
            this.buttonHit.Click += new System.EventHandler(this.buttonHit_Click);
            // 
            // buttonStay
            // 
            this.buttonStay.Location = new System.Drawing.Point(441, 308);
            this.buttonStay.Name = "buttonStay";
            this.buttonStay.Size = new System.Drawing.Size(81, 32);
            this.buttonStay.TabIndex = 1;
            this.buttonStay.Text = "Stay";
            this.buttonStay.UseVisualStyleBackColor = true;
            this.buttonStay.Click += new System.EventHandler(this.buttonStay_Click);
            // 
            // dealerHand
            // 
            this.dealerHand.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.dealerHand.ImageSize = new System.Drawing.Size(16, 16);
            this.dealerHand.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // playerHand
            // 
            this.playerHand.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.playerHand.ImageSize = new System.Drawing.Size(16, 16);
            this.playerHand.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // boxD2
            // 
            this.boxD2.Location = new System.Drawing.Point(473, 23);
            this.boxD2.Name = "boxD2";
            this.boxD2.Size = new System.Drawing.Size(73, 97);
            this.boxD2.TabIndex = 2;
            this.boxD2.TabStop = false;
            this.boxD2.Visible = false;
            // 
            // boxD1
            // 
            this.boxD1.Location = new System.Drawing.Point(460, 8);
            this.boxD1.Name = "boxD1";
            this.boxD1.Size = new System.Drawing.Size(73, 97);
            this.boxD1.TabIndex = 3;
            this.boxD1.TabStop = false;
            this.boxD1.Visible = false;
            // 
            // boxD3
            // 
            this.boxD3.Location = new System.Drawing.Point(487, 36);
            this.boxD3.Name = "boxD3";
            this.boxD3.Size = new System.Drawing.Size(73, 97);
            this.boxD3.TabIndex = 4;
            this.boxD3.TabStop = false;
            this.boxD3.Visible = false;
            // 
            // boxD4
            // 
            this.boxD4.Location = new System.Drawing.Point(501, 50);
            this.boxD4.Name = "boxD4";
            this.boxD4.Size = new System.Drawing.Size(73, 97);
            this.boxD4.TabIndex = 5;
            this.boxD4.TabStop = false;
            this.boxD4.Visible = false;
            // 
            // boxD5
            // 
            this.boxD5.Location = new System.Drawing.Point(514, 64);
            this.boxD5.Name = "boxD5";
            this.boxD5.Size = new System.Drawing.Size(73, 97);
            this.boxD5.TabIndex = 7;
            this.boxD5.TabStop = false;
            this.boxD5.Visible = false;
            // 
            // boxD6
            // 
            this.boxD6.Location = new System.Drawing.Point(526, 77);
            this.boxD6.Name = "boxD6";
            this.boxD6.Size = new System.Drawing.Size(73, 97);
            this.boxD6.TabIndex = 8;
            this.boxD6.TabStop = false;
            this.boxD6.Visible = false;
            // 
            // boxD7
            // 
            this.boxD7.Location = new System.Drawing.Point(539, 92);
            this.boxD7.Name = "boxD7";
            this.boxD7.Size = new System.Drawing.Size(73, 97);
            this.boxD7.TabIndex = 9;
            this.boxD7.TabStop = false;
            this.boxD7.Visible = false;
            // 
            // boxD8
            // 
            this.boxD8.Location = new System.Drawing.Point(552, 107);
            this.boxD8.Name = "boxD8";
            this.boxD8.Size = new System.Drawing.Size(73, 97);
            this.boxD8.TabIndex = 10;
            this.boxD8.TabStop = false;
            this.boxD8.Visible = false;
            // 
            // boxP8
            // 
            this.boxP8.Location = new System.Drawing.Point(114, 107);
            this.boxP8.Name = "boxP8";
            this.boxP8.Size = new System.Drawing.Size(73, 97);
            this.boxP8.TabIndex = 19;
            this.boxP8.TabStop = false;
            this.boxP8.Visible = false;
            // 
            // boxP7
            // 
            this.boxP7.Location = new System.Drawing.Point(99, 92);
            this.boxP7.Name = "boxP7";
            this.boxP7.Size = new System.Drawing.Size(73, 97);
            this.boxP7.TabIndex = 18;
            this.boxP7.TabStop = false;
            this.boxP7.Visible = false;
            // 
            // boxP6
            // 
            this.boxP6.Location = new System.Drawing.Point(85, 78);
            this.boxP6.Name = "boxP6";
            this.boxP6.Size = new System.Drawing.Size(73, 97);
            this.boxP6.TabIndex = 17;
            this.boxP6.TabStop = false;
            this.boxP6.Visible = false;
            // 
            // boxP5
            // 
            this.boxP5.Location = new System.Drawing.Point(71, 64);
            this.boxP5.Name = "boxP5";
            this.boxP5.Size = new System.Drawing.Size(73, 97);
            this.boxP5.TabIndex = 16;
            this.boxP5.TabStop = false;
            this.boxP5.Visible = false;
            // 
            // boxP4
            // 
            this.boxP4.Location = new System.Drawing.Point(57, 50);
            this.boxP4.Name = "boxP4";
            this.boxP4.Size = new System.Drawing.Size(73, 97);
            this.boxP4.TabIndex = 14;
            this.boxP4.TabStop = false;
            this.boxP4.Visible = false;
            // 
            // boxP3
            // 
            this.boxP3.Location = new System.Drawing.Point(43, 36);
            this.boxP3.Name = "boxP3";
            this.boxP3.Size = new System.Drawing.Size(73, 97);
            this.boxP3.TabIndex = 13;
            this.boxP3.TabStop = false;
            this.boxP3.Visible = false;
            // 
            // boxP1
            // 
            this.boxP1.Image = ((System.Drawing.Image)(resources.GetObject("boxP1.Image")));
            this.boxP1.Location = new System.Drawing.Point(14, 8);
            this.boxP1.Name = "boxP1";
            this.boxP1.Size = new System.Drawing.Size(73, 97);
            this.boxP1.TabIndex = 12;
            this.boxP1.TabStop = false;
            this.boxP1.Visible = false;
            // 
            // boxP2
            // 
            this.boxP2.Location = new System.Drawing.Point(28, 23);
            this.boxP2.Name = "boxP2";
            this.boxP2.Size = new System.Drawing.Size(73, 97);
            this.boxP2.TabIndex = 11;
            this.boxP2.TabStop = false;
            this.boxP2.Visible = false;
            this.boxP2.Click += new System.EventHandler(this.boxP2_Click);
            // 
            // labelPlayer
            // 
            this.labelPlayer.AutoSize = true;
            this.labelPlayer.Location = new System.Drawing.Point(27, 236);
            this.labelPlayer.Name = "labelPlayer";
            this.labelPlayer.Size = new System.Drawing.Size(36, 13);
            this.labelPlayer.TabIndex = 20;
            this.labelPlayer.Text = "Player";
            // 
            // labelDealer
            // 
            this.labelDealer.AutoSize = true;
            this.labelDealer.Location = new System.Drawing.Point(673, 210);
            this.labelDealer.Name = "labelDealer";
            this.labelDealer.Size = new System.Drawing.Size(38, 13);
            this.labelDealer.TabIndex = 21;
            this.labelDealer.Text = "Dealer";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Location = new System.Drawing.Point(259, 64);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(42, 13);
            this.lblMoney.TabIndex = 22;
            this.lblMoney.Text = "Money:";
            // 
            // textBet
            // 
            this.textBet.Location = new System.Drawing.Point(364, 254);
            this.textBet.Name = "textBet";
            this.textBet.Size = new System.Drawing.Size(64, 20);
            this.textBet.TabIndex = 23;
            // 
            // labelBetAmount
            // 
            this.labelBetAmount.AutoSize = true;
            this.labelBetAmount.Location = new System.Drawing.Point(295, 257);
            this.labelBetAmount.Name = "labelBetAmount";
            this.labelBetAmount.Size = new System.Drawing.Size(67, 13);
            this.labelBetAmount.TabIndex = 24;
            this.labelBetAmount.Text = "Bet amount :";
            // 
            // labelPlayerScore
            // 
            this.labelPlayerScore.AutoSize = true;
            this.labelPlayerScore.Location = new System.Drawing.Point(27, 210);
            this.labelPlayerScore.Name = "labelPlayerScore";
            this.labelPlayerScore.Size = new System.Drawing.Size(74, 13);
            this.labelPlayerScore.TabIndex = 25;
            this.labelPlayerScore.Text = "Points in hand";
            // 
            // labelDealerScore
            // 
            this.labelDealerScore.AutoSize = true;
            this.labelDealerScore.Location = new System.Drawing.Point(643, 180);
            this.labelDealerScore.Name = "labelDealerScore";
            this.labelDealerScore.Size = new System.Drawing.Size(102, 13);
            this.labelDealerScore.TabIndex = 26;
            this.labelDealerScore.Text = "Hidden dealer score";
            this.labelDealerScore.Visible = false;
            // 
            // buttonNewHand
            // 
            this.buttonNewHand.Location = new System.Drawing.Point(321, 313);
            this.buttonNewHand.Name = "buttonNewHand";
            this.buttonNewHand.Size = new System.Drawing.Size(75, 23);
            this.buttonNewHand.TabIndex = 27;
            this.buttonNewHand.Text = "New Hand";
            this.buttonNewHand.UseVisualStyleBackColor = true;
            this.buttonNewHand.Click += new System.EventHandler(this.buttonNewHand_Click);
            // 
            // buttonBet
            // 
            this.buttonBet.Location = new System.Drawing.Point(339, 280);
            this.buttonBet.Name = "buttonBet";
            this.buttonBet.Size = new System.Drawing.Size(57, 27);
            this.buttonBet.TabIndex = 28;
            this.buttonBet.Text = "Bet";
            this.buttonBet.UseVisualStyleBackColor = true;
            this.buttonBet.Click += new System.EventHandler(this.buttonBet_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(259, 91);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(34, 13);
            this.lblBalance.TabIndex = 29;
            this.lblBalance.Text = "20.00";
            // 
            // lblPot
            // 
            this.lblPot.AutoSize = true;
            this.lblPot.Location = new System.Drawing.Point(267, 162);
            this.lblPot.Name = "lblPot";
            this.lblPot.Size = new System.Drawing.Size(26, 13);
            this.lblPot.TabIndex = 30;
            this.lblPot.Text = "Pot:";
            // 
            // lblCurrentPot
            // 
            this.lblCurrentPot.AutoSize = true;
            this.lblCurrentPot.Location = new System.Drawing.Point(259, 181);
            this.lblCurrentPot.Name = "lblCurrentPot";
            this.lblCurrentPot.Size = new System.Drawing.Size(28, 13);
            this.lblCurrentPot.TabIndex = 31;
            this.lblCurrentPot.Text = "0.00";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(270, 356);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 32;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(380, 356);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 33;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "$";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 438);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.boxD8);
            this.Controls.Add(this.boxD7);
            this.Controls.Add(this.boxD6);
            this.Controls.Add(this.boxD5);
            this.Controls.Add(this.boxD4);
            this.Controls.Add(this.boxD3);
            this.Controls.Add(this.boxD2);
            this.Controls.Add(this.lblCurrentPot);
            this.Controls.Add(this.lblPot);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.buttonBet);
            this.Controls.Add(this.buttonNewHand);
            this.Controls.Add(this.labelDealerScore);
            this.Controls.Add(this.labelPlayerScore);
            this.Controls.Add(this.labelBetAmount);
            this.Controls.Add(this.textBet);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.labelDealer);
            this.Controls.Add(this.labelPlayer);
            this.Controls.Add(this.boxP8);
            this.Controls.Add(this.boxP7);
            this.Controls.Add(this.boxP6);
            this.Controls.Add(this.boxP5);
            this.Controls.Add(this.boxP4);
            this.Controls.Add(this.boxP3);
            this.Controls.Add(this.boxP2);
            this.Controls.Add(this.boxD1);
            this.Controls.Add(this.buttonStay);
            this.Controls.Add(this.buttonHit);
            this.Controls.Add(this.boxP1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.boxD2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxD1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxD3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxD4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxD5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxD6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxD7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxD8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxP8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxP7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxP6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxP5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxP4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxP3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxP2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonHit;
        private System.Windows.Forms.Button buttonStay;
        private System.Windows.Forms.ImageList dealerHand;
        private System.Windows.Forms.ImageList playerHand;
        private System.Windows.Forms.PictureBox boxD2;
        private System.Windows.Forms.PictureBox boxD1;
        private System.Windows.Forms.PictureBox boxD3;
        private System.Windows.Forms.PictureBox boxD4;
        private System.Windows.Forms.PictureBox boxD5;
        private System.Windows.Forms.PictureBox boxD6;
        private System.Windows.Forms.PictureBox boxD7;
        private System.Windows.Forms.PictureBox boxD8;
        private System.Windows.Forms.PictureBox boxP8;
        private System.Windows.Forms.PictureBox boxP7;
        private System.Windows.Forms.PictureBox boxP6;
        private System.Windows.Forms.PictureBox boxP5;
        private System.Windows.Forms.PictureBox boxP4;
        private System.Windows.Forms.PictureBox boxP3;
        private System.Windows.Forms.PictureBox boxP1;
        private System.Windows.Forms.PictureBox boxP2;
        private System.Windows.Forms.Label labelPlayer;
        private System.Windows.Forms.Label labelDealer;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.TextBox textBet;
        private System.Windows.Forms.Label labelBetAmount;
        private System.Windows.Forms.Label labelPlayerScore;
        private System.Windows.Forms.Label labelDealerScore;
        private System.Windows.Forms.Button buttonNewHand;
        private System.Windows.Forms.Button buttonBet;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblPot;
        private System.Windows.Forms.Label lblCurrentPot;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

