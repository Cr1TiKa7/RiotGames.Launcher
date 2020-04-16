namespace RiotGamesLauncher.Controls.CustomControls
{
    partial class SettingsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.customTextbox1 = new RiotGamesLauncher.Controls.CustomTextbox();
            this.cbCloseLauncherOnGameStart = new RiotGamesLauncher.Controls.CustomCheckBox();
            this.customControlBox1 = new CustomControlBox();
            this.btnSave = new RiotGamesLauncher.Controls.RoundButton();
            this.btnBrowse = new RiotGamesLauncher.Controls.RoundButton();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(24, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Close launcher on game start:";
            // 
            // customTextbox1
            // 
            this.customTextbox1.BackColor = System.Drawing.Color.Transparent;
            this.customTextbox1.FieldName = "RiotService.exe path";
            this.customTextbox1.Location = new System.Drawing.Point(27, 211);
            this.customTextbox1.Name = "customTextbox1";
            this.customTextbox1.Size = new System.Drawing.Size(221, 40);
            this.customTextbox1.TabIndex = 21;
            // 
            // cbCloseLauncherOnGameStart
            // 
            this.cbCloseLauncherOnGameStart.BackColor = System.Drawing.Color.Transparent;
            this.cbCloseLauncherOnGameStart.Checked = false;
            this.cbCloseLauncherOnGameStart.Location = new System.Drawing.Point(222, 257);
            this.cbCloseLauncherOnGameStart.Name = "cbCloseLauncherOnGameStart";
            this.cbCloseLauncherOnGameStart.Size = new System.Drawing.Size(39, 22);
            this.cbCloseLauncherOnGameStart.TabIndex = 19;
            // 
            // customControlBox1
            // 
            this.customControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.customControlBox1.Location = new System.Drawing.Point(875, 0);
            this.customControlBox1.MaximumSize = new System.Drawing.Size(80, 35);
            this.customControlBox1.Name = "customControlBox1";
            this.customControlBox1.Size = new System.Drawing.Size(80, 30);
            this.customControlBox1.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(54)))), ((int)(((byte)(57)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Icon = global::RiotGamesLauncher.Properties.Resources.baseline_save_white_48dp;
            this.btnSave.Location = new System.Drawing.Point(898, 473);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(45, 45);
            this.btnSave.TabIndex = 18;
            this.btnSave.Click += new System.EventHandler(this.OnBtnSaveClick);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.Transparent;
            this.btnBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBrowse.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnBrowse.Icon = global::RiotGamesLauncher.Properties.Resources.baseline_search_white_48dp;
            this.btnBrowse.Location = new System.Drawing.Point(254, 210);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(48, 40);
            this.btnBrowse.TabIndex = 17;
            this.btnBrowse.Click += new System.EventHandler(this.OnBtnSettingsClick);
            // 
            // SettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.customTextbox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbCloseLauncherOnGameStart);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.customControlBox1);
            this.Name = "SettingsControl";
            this.Size = new System.Drawing.Size(955, 534);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControlBox customControlBox1;
        private RoundButton btnSave;
        private System.Windows.Forms.Label label4;
        private CustomCheckBox cbCloseLauncherOnGameStart;
        private RoundButton btnBrowse;
        private CustomTextbox customTextbox1;
    }
}
