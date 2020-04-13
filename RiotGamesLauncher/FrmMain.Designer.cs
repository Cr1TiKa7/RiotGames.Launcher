using RiotGamesLauncher.Controls;

namespace RiotGamesLauncher
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRiotServicePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pbGitHub = new System.Windows.Forms.PictureBox();
            this.pbTwitch = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClose = new RiotGamesLauncher.Controls.RoundButton();
            this.cbCloseLauncherOnGameStart = new RiotGamesLauncher.Controls.CustomCheckBox();
            this.btnSave = new RiotGamesLauncher.Controls.RoundButton();
            this.btnBrowse = new RiotGamesLauncher.Controls.RoundButton();
            this.btnPlayValorant = new RiotGamesLauncher.Controls.PlayButton();
            this.btnPlayLol = new RiotGamesLauncher.Controls.PlayButton();
            this.btnPlayerLor = new RiotGamesLauncher.Controls.PlayButton();
            this.btnSettings = new RiotGamesLauncher.Controls.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlSettings.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGitHub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTwitch)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::RiotGamesLauncher.Properties.Resources.riotgames_logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 36);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblCopyright
            // 
            this.lblCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyright.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.ForeColor = System.Drawing.Color.White;
            this.lblCopyright.Location = new System.Drawing.Point(52, 3);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(214, 34);
            this.lblCopyright.TabIndex = 4;
            this.lblCopyright.Text = "© 2020 Cr1TiKa7\r\nAll rights belong to Riot Games Inc.";
            // 
            // pnlSettings
            // 
            this.pnlSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlSettings.Controls.Add(this.label4);
            this.pnlSettings.Controls.Add(this.cbCloseLauncherOnGameStart);
            this.pnlSettings.Controls.Add(this.btnSave);
            this.pnlSettings.Controls.Add(this.btnBrowse);
            this.pnlSettings.Controls.Add(this.label2);
            this.pnlSettings.Controls.Add(this.txtRiotServicePath);
            this.pnlSettings.Controls.Add(this.label1);
            this.pnlSettings.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSettings.Location = new System.Drawing.Point(0, 0);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(791, 534);
            this.pnlSettings.TabIndex = 9;
            this.pnlSettings.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Riot Service path:";
            // 
            // txtRiotServicePath
            // 
            this.txtRiotServicePath.Location = new System.Drawing.Point(17, 70);
            this.txtRiotServicePath.Name = "txtRiotServicePath";
            this.txtRiotServicePath.Size = new System.Drawing.Size(343, 22);
            this.txtRiotServicePath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Settings";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pbGitHub);
            this.panel1.Controls.Add(this.pbTwitch);
            this.panel1.Controls.Add(this.lblCopyright);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 534);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 42);
            this.panel1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(745, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "You can also find me on:";
            // 
            // pbGitHub
            // 
            this.pbGitHub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbGitHub.BackColor = System.Drawing.Color.Transparent;
            this.pbGitHub.BackgroundImage = global::RiotGamesLauncher.Properties.Resources.github;
            this.pbGitHub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbGitHub.Location = new System.Drawing.Point(902, 3);
            this.pbGitHub.Name = "pbGitHub";
            this.pbGitHub.Size = new System.Drawing.Size(34, 36);
            this.pbGitHub.TabIndex = 10;
            this.pbGitHub.TabStop = false;
            this.pbGitHub.Click += new System.EventHandler(this.OnPbGitHubClick);
            // 
            // pbTwitch
            // 
            this.pbTwitch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbTwitch.BackColor = System.Drawing.Color.Transparent;
            this.pbTwitch.BackgroundImage = global::RiotGamesLauncher.Properties.Resources.twitch;
            this.pbTwitch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbTwitch.Location = new System.Drawing.Point(942, 3);
            this.pbTwitch.Name = "pbTwitch";
            this.pbTwitch.Size = new System.Drawing.Size(34, 36);
            this.pbTwitch.TabIndex = 9;
            this.pbTwitch.TabStop = false;
            this.pbTwitch.Click += new System.EventHandler(this.OnPbTwitchClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Close launcher on game start:";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.BgColor = System.Drawing.Color.LightGray;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Icon = global::RiotGamesLauncher.Properties.Resources.baseline_close_black_48dp;
            this.btnClose.Location = new System.Drawing.Point(982, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 10;
            this.btnClose.Click += new System.EventHandler(this.OnBtnCloseClick);
            // 
            // cbCloseLauncherOnGameStart
            // 
            this.cbCloseLauncherOnGameStart.BackColor = System.Drawing.Color.Transparent;
            this.cbCloseLauncherOnGameStart.Checked = false;
            this.cbCloseLauncherOnGameStart.Location = new System.Drawing.Point(212, 103);
            this.cbCloseLauncherOnGameStart.Name = "cbCloseLauncherOnGameStart";
            this.cbCloseLauncherOnGameStart.Size = new System.Drawing.Size(39, 22);
            this.cbCloseLauncherOnGameStart.TabIndex = 13;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.BgColor = System.Drawing.Color.LightGray;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Icon = global::RiotGamesLauncher.Properties.Resources.baseline_save_black_48dp;
            this.btnSave.Location = new System.Drawing.Point(748, 489);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(30, 30);
            this.btnSave.TabIndex = 12;
            this.btnSave.Click += new System.EventHandler(this.OnBtnSaveClick);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.Transparent;
            this.btnBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBrowse.BgColor = System.Drawing.Color.LightGray;
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnBrowse.Icon = null;
            this.btnBrowse.Location = new System.Drawing.Point(366, 70);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(60, 22);
            this.btnBrowse.TabIndex = 11;
            this.btnBrowse.Click += new System.EventHandler(this.OnBtnBrowserLolClick);
            // 
            // btnPlayValorant
            // 
            this.btnPlayValorant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPlayValorant.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayValorant.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.btnPlayValorant.ForeColor = System.Drawing.Color.White;
            this.btnPlayValorant.Location = new System.Drawing.Point(342, 0);
            this.btnPlayValorant.Name = "btnPlayValorant";
            this.btnPlayValorant.Size = new System.Drawing.Size(341, 534);
            this.btnPlayValorant.TabIndex = 6;
            this.btnPlayValorant.Click += new System.EventHandler(this.OnBtnPlayValorant);
            // 
            // btnPlayLol
            // 
            this.btnPlayLol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPlayLol.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayLol.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.btnPlayLol.ForeColor = System.Drawing.Color.White;
            this.btnPlayLol.Location = new System.Drawing.Point(0, 0);
            this.btnPlayLol.Name = "btnPlayLol";
            this.btnPlayLol.Size = new System.Drawing.Size(341, 534);
            this.btnPlayLol.TabIndex = 5;
            this.btnPlayLol.Click += new System.EventHandler(this.OnBtnPlayLol);
            // 
            // btnPlayerLor
            // 
            this.btnPlayerLor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPlayerLor.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayerLor.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.btnPlayerLor.ForeColor = System.Drawing.Color.White;
            this.btnPlayerLor.Location = new System.Drawing.Point(684, 0);
            this.btnPlayerLor.Name = "btnPlayerLor";
            this.btnPlayerLor.Size = new System.Drawing.Size(341, 534);
            this.btnPlayerLor.TabIndex = 7;
            this.btnPlayerLor.Click += new System.EventHandler(this.OnBtnPlayLorClick);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSettings.BgColor = System.Drawing.Color.LightGray;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.Icon = global::RiotGamesLauncher.Properties.Resources.baseline_settings_black_48dp;
            this.btnSettings.Location = new System.Drawing.Point(982, 6);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(30, 30);
            this.btnSettings.TabIndex = 8;
            this.btnSettings.Click += new System.EventHandler(this.OnBtnSettingsClick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RiotGamesLauncher.Properties.Resources.riotgameslauncher_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 576);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlSettings);
            this.Controls.Add(this.btnPlayValorant);
            this.Controls.Add(this.btnPlayLol);
            this.Controls.Add(this.btnPlayerLor);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Riot Games Launcher by Cr1TiKa7";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlSettings.ResumeLayout(false);
            this.pnlSettings.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGitHub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTwitch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCopyright;
        private PlayButton btnPlayLol;
        private PlayButton btnPlayValorant;
        private PlayButton btnPlayerLor;
        private Controls.RoundButton btnSettings;
        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRiotServicePath;
        private System.Windows.Forms.Label label1;
        private Controls.RoundButton btnClose;
        private RoundButton btnBrowse;
        private RoundButton btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbGitHub;
        private System.Windows.Forms.PictureBox pbTwitch;
        private CustomCheckBox cbCloseLauncherOnGameStart;
        private System.Windows.Forms.Label label4;
    }
}

