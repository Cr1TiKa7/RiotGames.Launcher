using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using RiotGamesLauncher.Extensions;

namespace RiotGamesLauncher.Controls
{
    public partial class CustomCheckBox : UserControl
    {
        private bool _checked;

        [Browsable(true)]
        public bool Checked
        {
            get => _checked;
            set
            {
                _checked = value;
                Invalidate();
            }
        }

        public CustomCheckBox()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.InterpolationMode = InterpolationMode.High;
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

            if (!_checked)
            {
                e.Graphics.FillRoundedRectangle(new SolidBrush(Color.FromArgb(50, Color.LightGray)), new Rectangle(0, 1, Width, 19), 5);
                e.Graphics.FillRoundedRectangle(Brushes.LightGray, new Rectangle(0, 0, 10, 20), 5);
            }
            else
            {
                e.Graphics.FillRoundedRectangle(new SolidBrush(Color.FromArgb(191, 55, 59)), new Rectangle(0, 1, Width, 19), 5);
                e.Graphics.FillRoundedRectangle(Brushes.LightGray, new Rectangle(Width - 10, 0, 10, 20), 5);
            }
        }

        private void OnClick(object sender, System.EventArgs e)
        {
            _checked = !_checked;
            Invalidate();
        }
    }
}
