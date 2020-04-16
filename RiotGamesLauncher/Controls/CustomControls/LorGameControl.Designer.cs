namespace RiotGamesLauncher.Controls.CustomControls
{
    partial class LorGameControl
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
            this.playButton1 = new RiotGamesLauncher.Controls.PlayButton();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.customControlBox1 = new CustomControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // playButton1
            // 
            this.playButton1.BackColor = System.Drawing.Color.Transparent;
            this.playButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playButton1.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton1.ForeColor = System.Drawing.Color.White;
            this.playButton1.Location = new System.Drawing.Point(0, 0);
            this.playButton1.Name = "playButton1";
            this.playButton1.Size = new System.Drawing.Size(955, 534);
            this.playButton1.TabIndex = 0;
            this.playButton1.Click += new System.EventHandler(this.OnPlayButtonClick);
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbLogo.BackgroundImage = global::RiotGamesLauncher.Properties.Resources.Legends_of_Runeterra_logo;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogo.Location = new System.Drawing.Point(13, 459);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(190, 63);
            this.pbLogo.TabIndex = 2;
            this.pbLogo.TabStop = false;
            // 
            // customControlBox1
            // 
            this.customControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.customControlBox1.Location = new System.Drawing.Point(875, 0);
            this.customControlBox1.MaximumSize = new System.Drawing.Size(80, 35);
            this.customControlBox1.Name = "customControlBox1";
            this.customControlBox1.Size = new System.Drawing.Size(80, 30);
            this.customControlBox1.TabIndex = 3;
            // 
            // LorGameControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::RiotGamesLauncher.Properties.Resources.lor_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.customControlBox1);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.playButton1);
            this.Name = "LorGameControl";
            this.Size = new System.Drawing.Size(955, 534);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PlayButton playButton1;
        private System.Windows.Forms.PictureBox pbLogo;
        private CustomControlBox customControlBox1;
    }
}
