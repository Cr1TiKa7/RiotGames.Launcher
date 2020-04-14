using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Activation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RiotGamesLauncher.Controls
{
    public partial class CustomSideBar : UserControl
    {

        [Browsable(true)]
        public Image Icon { get; set; }
        [Browsable(true)]
        public List<CustomSideBarItem> Items = new List<CustomSideBarItem>();

        private int _hoveredIndex = -1;
        private int _selectedItemIndex = -1;


        public EventHandler<CustomSideBarItem> SideBarItemClick;

        public CustomSideBar()
        {
            InitializeComponent();
            BackColor = Utils.PrimaryColor;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (!Items.Any())
                return;

            for (int i = 0; i < Items.Count; i++)
            {
                var rectangle = new Rectangle(12, 12 + 60 * (i + 1), Width, 48);

                if (rectangle.IntersectsWith(new Rectangle(e.X, e.Y, 1, 1)))
                {
                    _hoveredIndex = i;
                    Invalidate();
                    return;
                }
            }

            _hoveredIndex = -1;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            _hoveredIndex = -1;
            Invalidate();
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            if (_hoveredIndex > -1 && _hoveredIndex < Items.Count)
            {
                SideBarItemClick?.Invoke(null, Items[_hoveredIndex]);
                _selectedItemIndex = _hoveredIndex;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (Icon != null)
                e.Graphics.DrawImage(Icon, new Rectangle(12,12,48,48));


            if (_hoveredIndex > -1)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(40,255,255,255)), new Rectangle(0, 12 + 60 * (_hoveredIndex + 1) - 6, Width, 60));
            }

            if (_selectedItemIndex > -1 && _selectedItemIndex< Items.Count)
            {
                var item = Items[_selectedItemIndex];
                e.Graphics.FillRectangle(new SolidBrush(item.AccentColor), new Rectangle(0, 12 + 60 * (_selectedItemIndex + 1) + 51, Width, 2));
            }

            for (int i = 0; i < Items.Count; i++)
            {
                var item = Items[i];

                if (item.Image != null)
                    e.Graphics.DrawImage(item.Image, new Rectangle(12,12 + 60 * (i + 1),48,48));
            }
        }
    }

    public class CustomSideBarItem
    {
        public string Text { get; set; }
        public Image Image { get; set; }
        public Color AccentColor { get; set; }
        public Control Control { get; set; }
    }
}
