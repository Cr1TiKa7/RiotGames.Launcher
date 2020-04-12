using System;
using System.Drawing;
using System.Runtime.ConstrainedExecution;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Threading.Timer;

namespace RiotGamesLauncher
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
                }
                else
                    fadeTimer.Stop();
            }
        }
    }
}
