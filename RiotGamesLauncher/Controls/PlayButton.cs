using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace RiotGamesLauncher.Controls
{
    public partial class PlayButton : UserControl
    {
        
        private Color _fontColor = Color.White;
        private StringFormat _stringFormat = new StringFormat();
        private int _fade = 0;
        private bool _isFading = true;
        public PlayButton()
        {
            InitializeComponent();
            _stringFormat.Alignment = StringAlignment.Center;
            _stringFormat.LineAlignment = StringAlignment.Center;
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.InterpolationMode = InterpolationMode.High;
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(_fade,0,0,0)),new Rectangle(0,0,Width,Height));
            e.Graphics.DrawString("Play", this.Font, new SolidBrush(ForeColor), new RectangleF(0, 0, Width, Height), _stringFormat);
        }


        private void OnFade(object sender, EventArgs e)
        {

        }
        private void OnMouseEnter(object sender, System.EventArgs e)
        {
            _isFading = false;
            fadeTimer.Start();
        }

        private void OnMouseLeave(object sender, System.EventArgs e)
        {
            _isFading = true;
            fadeTimer.Start();
        }

        private void OnFadeTick(object sender, EventArgs e)
        {
            if (_isFading)
            {
                if (_fade > 0)
                {
                    _fade -= 5;
                    Invalidate();
                    foreach (Control control in Parent.Controls)
                    {
                        control.BackColor = Color.FromArgb(_fade, 0, 0, 0);
                        control.Invalidate();
                    }
                }
                else
                    fadeTimer.Stop();

            }
            else
            {
                if (_fade < 100)
                {
                    _fade += 5;
                    Invalidate();
                    foreach (Control control in Parent.Controls)
                    {
                        control.BackColor = Color.FromArgb(_fade, 0, 0, 0);
                        control.Invalidate();
                    }
                }
                else
                    fadeTimer.Stop();
            }
        }
    }
}
