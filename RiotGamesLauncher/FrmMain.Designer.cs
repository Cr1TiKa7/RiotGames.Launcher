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
            this.lblCopyright = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pbGitHub = new System.Windows.Forms.PictureBox();
            this.pbTwitch = new System.Windows.Forms.PictureBox();
            this.pnlCustomControls = new System.Windows.Forms.Panel();
            this.pbPnlLogo = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.sideBar = new RiotGamesLauncher.Controls.CustomSideBar();
            this.customControlBox1 = new CustomControlBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGitHub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTwitch)).BeginInit();
            this.pnlCustomControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPnlLogo)).BeginInit();
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
            this.lblCopyright.Location = new System.Drawing.Point(6, 3);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(214, 34);
            this.lblCopyright.TabIndex = 4;
            this.lblCopyright.Text = "© 2020 Cr1TiKa7\r\nAll rights belong to Riot Games Inc.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pbGitHub);
            this.panel1.Controls.Add(this.pbTwitch);
            this.panel1.Controls.Add(this.lblCopyright);
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
            // pnlCustomControls
            // 
            this.pnlCustomControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.pnlCustomControls.Controls.Add(this.pbPnlLogo);
            this.pnlCustomControls.Location = new System.Drawing.Point(70, 0);
            this.pnlCustomControls.Name = "pnlCustomControls";
            this.pnlCustomControls.Size = new System.Drawing.Size(955, 534);
            this.pnlCustomControls.TabIndex = 13;
            this.pnlCustomControls.Visible = false;
            // 
            // pbPnlLogo
            // 
            this.pbPnlLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbPnlLogo.BackgroundImage = global::RiotGamesLauncher.Properties.Resources.launcher_bg;
            this.pbPnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPnlLogo.Location = new System.Drawing.Point(283, 178);
            this.pbPnlLogo.Name = "pbPnlLogo";
            this.pbPnlLogo.Size = new System.Drawing.Size(389, 179);
            this.pbPnlLogo.TabIndex = 15;
            this.pbPnlLogo.TabStop = false;
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGitHub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTwitch)).EndInit();
            this.pnlCustomControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPnlLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbGitHub;
        private System.Windows.Forms.PictureBox pbTwitch;
        private CustomSideBar sideBar;
        private System.Windows.Forms.Panel pnlCustomControls;
        private System.Windows.Forms.PictureBox pbLogo;
        private CustomControlBox customControlBox1;
        private System.Windows.Forms.PictureBox pbPnlLogo;
    }
}

