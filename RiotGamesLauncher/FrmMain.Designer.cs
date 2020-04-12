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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.btnPlayerLor = new RiotGamesLauncher.PlayButton();
            this.btnPlayValorant = new RiotGamesLauncher.PlayButton();
            this.btnPlayLol = new RiotGamesLauncher.PlayButton();
            this.btnSettings = new RiotGamesLauncher.Controls.RoundButton();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBrowseLegendsOfRuneterra = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLor = new System.Windows.Forms.TextBox();
            this.btnBrowseValorant = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorant = new System.Windows.Forms.TextBox();
            this.btnBrowseLol = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new RiotGamesLauncher.Controls.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::RiotGamesLauncher.Properties.Resources.riotgames_logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 514);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblCopyright
            // 
            this.lblCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyright.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.ForeColor = System.Drawing.Color.Black;
            this.lblCopyright.Location = new System.Drawing.Point(90, 520);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(214, 34);
            this.lblCopyright.TabIndex = 4;
            this.lblCopyright.Text = "© 2020 Cr1TiKa7\r\nAll rights belong to Riot Games Inc.";
            // 
            // btnPlayerLor
            // 
            this.btnPlayerLor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPlayerLor.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayerLor.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.btnPlayerLor.ForeColor = System.Drawing.Color.White;
            this.btnPlayerLor.Location = new System.Drawing.Point(684, 0);
            this.btnPlayerLor.Name = "btnPlayerLor";
            this.btnPlayerLor.Size = new System.Drawing.Size(341, 576);
            this.btnPlayerLor.TabIndex = 7;
            this.btnPlayerLor.Click += new System.EventHandler(this.OnBtnPlayLorClick);
            // 
            // btnPlayValorant
            // 
            this.btnPlayValorant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPlayValorant.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayValorant.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.btnPlayValorant.ForeColor = System.Drawing.Color.White;
            this.btnPlayValorant.Location = new System.Drawing.Point(342, 0);
            this.btnPlayValorant.Name = "btnPlayValorant";
            this.btnPlayValorant.Size = new System.Drawing.Size(341, 576);
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
            this.btnPlayLol.Size = new System.Drawing.Size(341, 576);
            this.btnPlayLol.TabIndex = 5;
            this.btnPlayLol.Click += new System.EventHandler(this.OnBtnPlayLol);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.Icon = global::RiotGamesLauncher.Properties.Resources.baseline_settings_black_48dp;
            this.btnSettings.Location = new System.Drawing.Point(982, 534);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(30, 30);
            this.btnSettings.TabIndex = 8;
            this.btnSettings.Visible = false;
            this.btnSettings.Click += new System.EventHandler(this.OnBtnSettingsClick);
            // 
            // pnlSettings
            // 
            this.pnlSettings.BackColor = System.Drawing.Color.Black;
            this.pnlSettings.Controls.Add(this.btnSave);
            this.pnlSettings.Controls.Add(this.btnBrowseLegendsOfRuneterra);
            this.pnlSettings.Controls.Add(this.label4);
            this.pnlSettings.Controls.Add(this.txtLor);
            this.pnlSettings.Controls.Add(this.btnBrowseValorant);
            this.pnlSettings.Controls.Add(this.label3);
            this.pnlSettings.Controls.Add(this.txtValorant);
            this.pnlSettings.Controls.Add(this.btnBrowseLol);
            this.pnlSettings.Controls.Add(this.label2);
            this.pnlSettings.Controls.Add(this.txtLol);
            this.pnlSettings.Controls.Add(this.label1);
            this.pnlSettings.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSettings.Location = new System.Drawing.Point(0, 0);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(792, 576);
            this.pnlSettings.TabIndex = 9;
            this.pnlSettings.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(700, 541);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.OnBtnSaveClick);
            // 
            // btnBrowseLegendsOfRuneterra
            // 
            this.btnBrowseLegendsOfRuneterra.Location = new System.Drawing.Point(366, 185);
            this.btnBrowseLegendsOfRuneterra.Name = "btnBrowseLegendsOfRuneterra";
            this.btnBrowseLegendsOfRuneterra.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseLegendsOfRuneterra.TabIndex = 9;
            this.btnBrowseLegendsOfRuneterra.Text = "Browse";
            this.btnBrowseLegendsOfRuneterra.UseVisualStyleBackColor = true;
            this.btnBrowseLegendsOfRuneterra.Click += new System.EventHandler(this.OnBtnBrowseLegendsOfRuneterra);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Legends of Runeterra path:";
            // 
            // txtLor
            // 
            this.txtLor.Location = new System.Drawing.Point(17, 185);
            this.txtLor.Name = "txtLor";
            this.txtLor.Size = new System.Drawing.Size(343, 22);
            this.txtLor.TabIndex = 7;
            // 
            // btnBrowseValorant
            // 
            this.btnBrowseValorant.Location = new System.Drawing.Point(366, 126);
            this.btnBrowseValorant.Name = "btnBrowseValorant";
            this.btnBrowseValorant.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseValorant.TabIndex = 6;
            this.btnBrowseValorant.Text = "Browse";
            this.btnBrowseValorant.UseVisualStyleBackColor = true;
            this.btnBrowseValorant.Click += new System.EventHandler(this.OnBtnBrowseValorantClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valorant path:";
            // 
            // txtValorant
            // 
            this.txtValorant.Location = new System.Drawing.Point(17, 126);
            this.txtValorant.Name = "txtValorant";
            this.txtValorant.Size = new System.Drawing.Size(343, 22);
            this.txtValorant.TabIndex = 4;
            // 
            // btnBrowseLol
            // 
            this.btnBrowseLol.Location = new System.Drawing.Point(366, 70);
            this.btnBrowseLol.Name = "btnBrowseLol";
            this.btnBrowseLol.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseLol.TabIndex = 3;
            this.btnBrowseLol.Text = "Browse";
            this.btnBrowseLol.UseVisualStyleBackColor = true;
            this.btnBrowseLol.Click += new System.EventHandler(this.OnBtnBrowserLolClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "League of Legends path:";
            // 
            // txtLol
            // 
            this.txtLol.Location = new System.Drawing.Point(17, 70);
            this.txtLol.Name = "txtLol";
            this.txtLol.Size = new System.Drawing.Size(343, 22);
            this.txtLol.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Settings";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Icon = global::RiotGamesLauncher.Properties.Resources.baseline_close_black_48dp;
            this.btnClose.Location = new System.Drawing.Point(982, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 10;
            this.btnClose.Click += new System.EventHandler(this.OnBtnCloseClick);
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
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnPlayerLor);
            this.Controls.Add(this.btnPlayValorant);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPlayLol);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Riot Games Launcher by Cr1TiKa7";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlSettings.ResumeLayout(false);
            this.pnlSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCopyright;
        private PlayButton btnPlayLol;
        private PlayButton btnPlayValorant;
        private PlayButton btnPlayerLor;
        private Controls.RoundButton btnSettings;
        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.Button btnBrowseLol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBrowseLegendsOfRuneterra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLor;
        private System.Windows.Forms.Button btnBrowseValorant;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValorant;
        private Controls.RoundButton btnClose;
    }
}

