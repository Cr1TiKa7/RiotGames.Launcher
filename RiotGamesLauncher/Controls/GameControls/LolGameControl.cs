using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RiotGamesLauncher.Models;

namespace RiotGamesLauncher.Controls.GameControls
{
    public partial class LolGameControl : UserControl
    {
        private readonly Settings _settings;
        private readonly GameInfo _game;

        public LolGameControl(Settings settings, GameInfo game)
        {
            _settings = settings;
            _game = game;
            InitializeComponent();
        }

        private void OnPlayButtonClick(object sender, EventArgs e)
        {
            if (_game != null)
            {
                var processInfo = new ProcessStartInfo(_game.Location, _game.PathAddition);
                Process.Start(processInfo);
                var loadingIndicator = new LoadingIndicator();
                Controls.Add(loadingIndicator);
                loadingIndicator.GameInfo = _game;
                loadingIndicator.Location = new Point(342, 179);
                loadingIndicator.BringToFront();
                if (_settings != null && _settings.CloseLauncherOnGameStart)
                    ParentForm?.Close();
            }
            else
                MessageBox.Show(this,
                    "The game path couldn't been located. Please select the right location in the settings tab.",
                    "Game location not found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }
    }
}
