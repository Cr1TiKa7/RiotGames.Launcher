using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using RiotGamesLauncher.Extensions;

namespace RiotGamesLauncher.Controls
{
    public partial class RoundButton : UserControl
    {
        [Browsable(true)]
        public Image Icon { get; set; }

        public RoundButton()
        {
            InitializeComponent();
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.InterpolationMode = InterpolationMode.High;
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.FillRoundedRectangle(Brushes.DimGray, new Rectangle(0,0,Width,Height),5);

            if (Icon != null)
                e.Graphics.DrawImage(Icon, new Rectangle(0,0,Width,Height),
             new Rectangle(0,0, Icon.Width, Icon.Height),
             GraphicsUnit.Pixel);
        }
    }
}
