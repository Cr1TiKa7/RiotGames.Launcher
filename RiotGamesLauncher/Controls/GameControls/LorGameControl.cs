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
    public partial class LorGameControl : UserControl
    {
        private readonly Settings _settings;
        private readonly GameInfo _game;

        public LorGameControl(Settings settings, GameInfo game)
        {
            _settings = settings;
            _game = game;
            InitializeComponent();
        }

        private void OnPlayButtonClick(object sender, EventArgs e)
        {

        }
    }
}
