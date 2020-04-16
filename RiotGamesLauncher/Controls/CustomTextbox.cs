using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using RiotGamesLauncher.Extensions;

namespace RiotGamesLauncher.Controls
{
    public partial class CustomTextbox : UserControl
    {
        private string _text;
        private string _fieldName;

        [Browsable(true)]
        public string FieldName
        {
            get => _fieldName;
            set
            {
                _fieldName = value;
                lblHeader.Text = _fieldName;
            }
        }

        [Browsable(true)]
        public string Text
        {
            get => _text;
            set
            {
                _text = value;
                txtText.Text = _text;
            }
        }

        private Color _backColor = Color.FromArgb(229, 229, 229);
        public CustomTextbox()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBilinear;
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.FillRoundedRectangle(new SolidBrush(_backColor),new Rectangle(0,0,Width,Height), 10);
        }

        private void txtText_TextChanged(object sender, System.EventArgs e)
        {

        }
    }
}
