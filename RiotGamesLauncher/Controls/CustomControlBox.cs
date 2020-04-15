using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace RiotGamesLauncher.Controls.GameControls
{
    public partial class CustomControlBox : UserControl
    {
        private Pen _seperatorPen = new Pen(Color.FromArgb(40,255,255,255),1f);
        private int _hoveredIndex = -1;
        public CustomControlBox()
        {
            InitializeComponent();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            var mouseRect = new Rectangle(e.X,e.Y,1,1);

            if (mouseRect.IntersectsWith(new Rectangle(0, 0, 40, Height)))
                _hoveredIndex = 0;
            else
                _hoveredIndex = 1;

            Invalidate();

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.InterpolationMode = InterpolationMode.High;
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;


            if (_hoveredIndex > -1)
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(40, 255, 255, 255)), new Rectangle(0 + 40 * _hoveredIndex, 0, 40, Height));


            e.Graphics.DrawLine(_seperatorPen, new Point(Width / 2, 2), new Point(Width / 2, Height - 4));


            //Minimize icon
            e.Graphics.DrawLine(Pens.White, new Point(10, Height / 2), new Point(30, Height / 2));
            //Close Icon
            e.Graphics.DrawLine(Pens.White, new Point( 52, 7),new Point(68,23));
            e.Graphics.DrawLine(Pens.White, new Point( 52, 23),new Point(68,7));
        }
    }
}
