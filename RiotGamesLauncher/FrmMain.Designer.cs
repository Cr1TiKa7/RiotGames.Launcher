﻿using RiotGamesLauncher.Controls;

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
            this.lblCopyright = new System.Windows.Forms.Label();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRiotServicePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pbGitHub = new System.Windows.Forms.PictureBox();
            this.pbTwitch = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlCustomControls = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.sideBar = new RiotGamesLauncher.Controls.CustomSideBar();
            this.cbCloseLauncherOnGameStart = new RiotGamesLauncher.Controls.CustomCheckBox();
            this.btnSave = new RiotGamesLauncher.Controls.RoundButton();
            this.btnBrowse = new RiotGamesLauncher.Controls.RoundButton();
            this.btnSettings = new RiotGamesLauncher.Controls.RoundButton();
            this.customControlBox1 = new RiotGamesLauncher.Controls.GameControls.CustomControlBox();
            this.pnlSettings.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGitHub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTwitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
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
            this.pnlSettings.Location = new System.Drawing.Point(415, 25);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(156, 54);
            this.pnlSettings.TabIndex = 9;
            this.pnlSettings.Visible = false;
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
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.pnlSettings);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pbGitHub);
            this.panel1.Controls.Add(this.pbTwitch);
            this.panel1.Controls.Add(this.lblCopyright);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(70, 534);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 42);
            this.panel1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(712, 11);
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
            this.pbGitHub.Location = new System.Drawing.Point(869, 3);
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
            this.pbTwitch.Location = new System.Drawing.Point(909, 3);
            this.pbTwitch.Name = "pbTwitch";
            this.pbTwitch.Size = new System.Drawing.Size(34, 36);
            this.pbTwitch.TabIndex = 9;
            this.pbTwitch.TabStop = false;
            this.pbTwitch.Click += new System.EventHandler(this.OnPbTwitchClick);
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
            // pnlCustomControls
            // 
            this.pnlCustomControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.pnlCustomControls.Location = new System.Drawing.Point(70, 0);
            this.pnlCustomControls.Name = "pnlCustomControls";
            this.pnlCustomControls.Size = new System.Drawing.Size(955, 534);
            this.pnlCustomControls.TabIndex = 13;
            this.pnlCustomControls.Visible = false;
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbLogo.BackgroundImage = global::RiotGamesLauncher.Properties.Resources.launcher_bg;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogo.Location = new System.Drawing.Point(308, 179);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(389, 179);
            this.pbLogo.TabIndex = 14;
            this.pbLogo.TabStop = false;
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar.Icon = global::RiotGamesLauncher.Properties.Resources.riotgames_logo;
            this.sideBar.Location = new System.Drawing.Point(0, 0);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(70, 576);
            this.sideBar.TabIndex = 12;
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
            this.btnSave.Location = new System.Drawing.Point(113, 9);
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
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSettings.BgColor = System.Drawing.Color.LightGray;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.Icon = global::RiotGamesLauncher.Properties.Resources.baseline_settings_white_48dp;
            this.btnSettings.Location = new System.Drawing.Point(982, 6);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(30, 30);
            this.btnSettings.TabIndex = 8;
            this.btnSettings.Click += new System.EventHandler(this.OnBtnSettingsClick);
            // 
            // customControlBox1
            // 
            this.customControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.customControlBox1.Location = new System.Drawing.Point(945, 0);
            this.customControlBox1.MaximumSize = new System.Drawing.Size(80, 35);
            this.customControlBox1.Name = "customControlBox1";
            this.customControlBox1.Size = new System.Drawing.Size(80, 30);
            this.customControlBox1.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 576);
            this.Controls.Add(this.pnlCustomControls);
            this.Controls.Add(this.sideBar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.customControlBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Riot Games Launcher by Cr1TiKa7";
            this.pnlSettings.ResumeLayout(false);
            this.pnlSettings.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGitHub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTwitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCopyright;
        private Controls.RoundButton btnSettings;
        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRiotServicePath;
        private System.Windows.Forms.Label label1;
        private RoundButton btnBrowse;
        private RoundButton btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbGitHub;
        private System.Windows.Forms.PictureBox pbTwitch;
        private CustomCheckBox cbCloseLauncherOnGameStart;
        private System.Windows.Forms.Label label4;
        private CustomSideBar sideBar;
        private System.Windows.Forms.Panel pnlCustomControls;
        private System.Windows.Forms.PictureBox pbLogo;
        private Controls.GameControls.CustomControlBox customControlBox1;
    }
}

