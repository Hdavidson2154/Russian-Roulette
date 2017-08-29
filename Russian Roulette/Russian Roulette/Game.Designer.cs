namespace Russian_Roulette
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.btnFire = new System.Windows.Forms.Button();
            this.RbAtTrump = new System.Windows.Forms.RadioButton();
            this.RbAtYou = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.GunShot = new AxWMPLib.AxWindowsMediaPlayer();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.GunLoad = new AxWMPLib.AxWindowsMediaPlayer();
            this.lblShotCount = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            this.PbBullet6 = new System.Windows.Forms.PictureBox();
            this.PbBullet2 = new System.Windows.Forms.PictureBox();
            this.PbBullet3 = new System.Windows.Forms.PictureBox();
            this.PbBullet4 = new System.Windows.Forms.PictureBox();
            this.PbBullet5 = new System.Windows.Forms.PictureBox();
            this.PbBullet1 = new System.Windows.Forms.PictureBox();
            this.pbGun = new System.Windows.Forms.PictureBox();
            this.PbPlayer = new System.Windows.Forms.PictureBox();
            this.PBOpponent = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GunShot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GunLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbBullet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbBullet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbBullet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbBullet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbBullet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbBullet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBOpponent)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFire
            // 
            this.btnFire.Location = new System.Drawing.Point(313, 315);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(127, 83);
            this.btnFire.TabIndex = 4;
            this.btnFire.Text = "Fire";
            this.btnFire.UseVisualStyleBackColor = true;
            this.btnFire.Click += new System.EventHandler(this.btnFire_Click);
            // 
            // RbAtTrump
            // 
            this.RbAtTrump.AutoSize = true;
            this.RbAtTrump.Location = new System.Drawing.Point(329, 12);
            this.RbAtTrump.Name = "RbAtTrump";
            this.RbAtTrump.Size = new System.Drawing.Size(94, 17);
            this.RbAtTrump.TabIndex = 10;
            this.RbAtTrump.TabStop = true;
            this.RbAtTrump.Text = "Point at Trump";
            this.RbAtTrump.UseVisualStyleBackColor = true;
            this.RbAtTrump.CheckedChanged += new System.EventHandler(this.RbAtTrump_CheckedChanged);
            // 
            // RbAtYou
            // 
            this.RbAtYou.AutoSize = true;
            this.RbAtYou.Location = new System.Drawing.Point(478, 12);
            this.RbAtYou.Name = "RbAtYou";
            this.RbAtYou.Size = new System.Drawing.Size(98, 17);
            this.RbAtYou.TabIndex = 11;
            this.RbAtYou.TabStop = true;
            this.RbAtYou.Text = "Point at Rambo";
            this.RbAtYou.UseVisualStyleBackColor = true;
            this.RbAtYou.CheckedChanged += new System.EventHandler(this.RbAtYou_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 42);
            this.label1.TabIndex = 12;
            this.label1.Text = "Russian Roulette";
            // 
            // GunShot
            // 
            this.GunShot.Enabled = true;
            this.GunShot.Location = new System.Drawing.Point(892, 551);
            this.GunShot.Name = "GunShot";
            this.GunShot.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("GunShot.OcxState")));
            this.GunShot.Size = new System.Drawing.Size(8, 13);
            this.GunShot.TabIndex = 13;
            this.GunShot.Enter += new System.EventHandler(this.GunShot_Enter);
            // 
            // BtnLoad
            // 
            this.BtnLoad.Location = new System.Drawing.Point(460, 315);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(127, 83);
            this.BtnLoad.TabIndex = 14;
            this.BtnLoad.Text = "Load The Chamber";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // GunLoad
            // 
            this.GunLoad.Enabled = true;
            this.GunLoad.Location = new System.Drawing.Point(892, 519);
            this.GunLoad.Name = "GunLoad";
            this.GunLoad.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("GunLoad.OcxState")));
            this.GunLoad.Size = new System.Drawing.Size(8, 13);
            this.GunLoad.TabIndex = 16;
            // 
            // lblShotCount
            // 
            this.lblShotCount.AutoSize = true;
            this.lblShotCount.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShotCount.Location = new System.Drawing.Point(396, 281);
            this.lblShotCount.Name = "lblShotCount";
            this.lblShotCount.Size = new System.Drawing.Size(105, 16);
            this.lblShotCount.TabIndex = 18;
            this.lblShotCount.Text = "Shot Count: 6";
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.DimGray;
            this.BtnExit.Image = global::Russian_Roulette.Properties.Resources.Exit;
            this.BtnExit.Location = new System.Drawing.Point(837, 0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(63, 59);
            this.BtnExit.TabIndex = 17;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // PbBullet6
            // 
            this.PbBullet6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PbBullet6.BackgroundImage")));
            this.PbBullet6.Location = new System.Drawing.Point(849, 399);
            this.PbBullet6.Name = "PbBullet6";
            this.PbBullet6.Size = new System.Drawing.Size(50, 165);
            this.PbBullet6.TabIndex = 9;
            this.PbBullet6.TabStop = false;
            // 
            // PbBullet2
            // 
            this.PbBullet2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PbBullet2.BackgroundImage")));
            this.PbBullet2.Location = new System.Drawing.Point(645, 399);
            this.PbBullet2.Name = "PbBullet2";
            this.PbBullet2.Size = new System.Drawing.Size(50, 165);
            this.PbBullet2.TabIndex = 8;
            this.PbBullet2.TabStop = false;
            // 
            // PbBullet3
            // 
            this.PbBullet3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PbBullet3.BackgroundImage")));
            this.PbBullet3.Location = new System.Drawing.Point(696, 399);
            this.PbBullet3.Name = "PbBullet3";
            this.PbBullet3.Size = new System.Drawing.Size(50, 165);
            this.PbBullet3.TabIndex = 7;
            this.PbBullet3.TabStop = false;
            this.PbBullet3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // PbBullet4
            // 
            this.PbBullet4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PbBullet4.BackgroundImage")));
            this.PbBullet4.Location = new System.Drawing.Point(747, 399);
            this.PbBullet4.Name = "PbBullet4";
            this.PbBullet4.Size = new System.Drawing.Size(50, 165);
            this.PbBullet4.TabIndex = 6;
            this.PbBullet4.TabStop = false;
            // 
            // PbBullet5
            // 
            this.PbBullet5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PbBullet5.BackgroundImage")));
            this.PbBullet5.Location = new System.Drawing.Point(798, 399);
            this.PbBullet5.Name = "PbBullet5";
            this.PbBullet5.Size = new System.Drawing.Size(50, 165);
            this.PbBullet5.TabIndex = 5;
            this.PbBullet5.TabStop = false;
            // 
            // PbBullet1
            // 
            this.PbBullet1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PbBullet1.BackgroundImage")));
            this.PbBullet1.Location = new System.Drawing.Point(593, 399);
            this.PbBullet1.Name = "PbBullet1";
            this.PbBullet1.Size = new System.Drawing.Size(50, 165);
            this.PbBullet1.TabIndex = 3;
            this.PbBullet1.TabStop = false;
            this.PbBullet1.Click += new System.EventHandler(this.pbBullet1_Click);
            // 
            // pbGun
            // 
            this.pbGun.BackgroundImage = global::Russian_Roulette.Properties.Resources.GunReverse;
            this.pbGun.Location = new System.Drawing.Point(307, 79);
            this.pbGun.Name = "pbGun";
            this.pbGun.Size = new System.Drawing.Size(286, 218);
            this.pbGun.TabIndex = 2;
            this.pbGun.TabStop = false;
            // 
            // PbPlayer
            // 
            this.PbPlayer.BackgroundImage = global::Russian_Roulette.Properties.Resources._3;
            this.PbPlayer.Location = new System.Drawing.Point(593, 0);
            this.PbPlayer.Name = "PbPlayer";
            this.PbPlayer.Size = new System.Drawing.Size(307, 398);
            this.PbPlayer.TabIndex = 1;
            this.PbPlayer.TabStop = false;
            this.PbPlayer.Click += new System.EventHandler(this.PbPlayer_Click);
            // 
            // PBOpponent
            // 
            this.PBOpponent.BackgroundImage = global::Russian_Roulette.Properties.Resources.ggfgf;
            this.PBOpponent.Location = new System.Drawing.Point(0, 0);
            this.PBOpponent.Name = "PBOpponent";
            this.PBOpponent.Size = new System.Drawing.Size(307, 398);
            this.PBOpponent.TabIndex = 0;
            this.PBOpponent.TabStop = false;
            this.PBOpponent.Click += new System.EventHandler(this.PBOpponent_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(900, 561);
            this.Controls.Add(this.lblShotCount);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.GunLoad);
            this.Controls.Add(this.BtnLoad);
            this.Controls.Add(this.GunShot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RbAtYou);
            this.Controls.Add(this.RbAtTrump);
            this.Controls.Add(this.PbBullet6);
            this.Controls.Add(this.PbBullet2);
            this.Controls.Add(this.PbBullet3);
            this.Controls.Add(this.PbBullet4);
            this.Controls.Add(this.PbBullet5);
            this.Controls.Add(this.btnFire);
            this.Controls.Add(this.PbBullet1);
            this.Controls.Add(this.pbGun);
            this.Controls.Add(this.PbPlayer);
            this.Controls.Add(this.PBOpponent);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GunShot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GunLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbBullet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbBullet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbBullet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbBullet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbBullet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbBullet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBOpponent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBOpponent;
        private System.Windows.Forms.PictureBox PbPlayer;
        private System.Windows.Forms.PictureBox pbGun;
        private System.Windows.Forms.PictureBox PbBullet1;
        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.PictureBox PbBullet5;
        private System.Windows.Forms.PictureBox PbBullet4;
        private System.Windows.Forms.PictureBox PbBullet3;
        private System.Windows.Forms.PictureBox PbBullet2;
        private System.Windows.Forms.PictureBox PbBullet6;
        private System.Windows.Forms.RadioButton RbAtTrump;
        private System.Windows.Forms.RadioButton RbAtYou;
        private System.Windows.Forms.Label label1;
        private AxWMPLib.AxWindowsMediaPlayer GunShot;
        private System.Windows.Forms.Button BtnLoad;
        private AxWMPLib.AxWindowsMediaPlayer GunLoad;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label lblShotCount;
    }
}