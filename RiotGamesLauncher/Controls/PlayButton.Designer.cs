namespace RiotGamesLauncher
{
    partial class PlayButton
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
            this.components = new System.ComponentModel.Container();
            this.fadeTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // fadeTimer
            // 
            this.fadeTimer.Interval = 10;
            this.fadeTimer.Tick += new System.EventHandler(this.OnFadeTick);
            // 
            // PlayButton
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.Name = "PlayButton";
            this.Size = new System.Drawing.Size(152, 88);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer fadeTimer;
    }
}
