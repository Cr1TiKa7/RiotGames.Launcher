using System.Drawing;
using System.Windows.Forms;
using RiotGamesLauncher.Models;
using RiotGamesLauncher.Models.Types;

namespace RiotGamesLauncher.Controls
{
    public partial class LoadingIndicator : UserControl
    {
        private GameInfo _gameInfo;
        private SolidBrush _progressBarBrush = new SolidBrush(Color.Gray);
        private const int _progressBarWidth = 140;
        private int _progress = 0 - _progressBarWidth;
        private int _maxShowTime = 15000;
        public GameInfo GameInfo
        {
            get => _gameInfo;
            set
            {
                _gameInfo = value;
                if (_gameInfo != null)
                {
                    lblGameName.Text = $"Starting: {_gameInfo.Name}";
                    SetColorByGameType(_gameInfo.Type);
                }
            }
        }

        public LoadingIndicator()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(_progressBarBrush,new Rectangle(_progress, Height - 10,_progressBarWidth,10));
        }
        private void SetColorByGameType(GameType gameInfoType)
        {
            switch (gameInfoType)
            {
                case GameType.LegendsOfRuneterra:
                    _progressBarBrush = new SolidBrush(Color.FromArgb(238,135,12));
                    break;
                case GameType.LeagueOfLegends:
                    _progressBarBrush = new SolidBrush(Color.FromArgb(63, 158, 255));
                    break;
                case GameType.Valorant:
                    _progressBarBrush = new SolidBrush(Color.FromArgb(191, 55, 59));
                    break;
            }
        }

        private void OnTick(object sender, System.EventArgs e)
        {
            _progress += 5;
            if (_progress > Width)
                _progress = 0 - _progressBarWidth;
            _maxShowTime -= 20;

            if (_maxShowTime < 0 && Parent != null)
                Parent.Controls.Remove(this);
            Invalidate(new Rectangle(0,Height-10, Width,10));
        }
    }
}
