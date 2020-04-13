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
        [Browsable(true)]
        public string Text { get; set; }

        [Browsable(true)] public Color BgColor { get; set; } = Color.LightGray;

        private StringFormat _stringFormat = new StringFormat();

        private readonly SolidBrush _buttonColor;
        public RoundButton()
        {
            InitializeComponent();
            _buttonColor= new SolidBrush(Color.FromArgb(100,Color.LightGray));
            _stringFormat.Alignment = StringAlignment.Center;
            _stringFormat.LineAlignment = StringAlignment.Center;
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.InterpolationMode = InterpolationMode.High;
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.FillRoundedRectangle(new SolidBrush(BgColor), new Rectangle(0,0,Width,Height),5);

            if (Icon != null)
                e.Graphics.DrawImage(Icon, new Rectangle(0,0,Width,Height),
             new Rectangle(0,0, Icon.Width, Icon.Height),
             GraphicsUnit.Pixel);
            else
                e.Graphics.DrawString("Browse", Font,new SolidBrush(ForeColor), new Rectangle(0,0,Width,Height),_stringFormat);
        }
    }
}
