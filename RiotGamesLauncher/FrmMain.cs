using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using RiotGamesLauncher.Controls;
using RiotGamesLauncher.Controls.GameControls;
using RiotGamesLauncher.Models;
using RiotGamesLauncher.Models.Types;
using RiotGamesLauncher.Properties;
using RiotGamesLauncher.Services;
using Settings = RiotGamesLauncher.Models.Settings;

namespace RiotGamesLauncher
{
    public partial class FrmMain : Form
    {
        private GameLocatorService _gameLocatorService = new GameLocatorService();
        private List<GameInfo> _gameInfos = new List<GameInfo>();
        private Settings _settings = new Settings();
        public FrmMain()
        {
            InitializeComponent();
            InitializeSettings();
            InitializeSideBar();
        }

        private void InitializeSideBar()
        {
            sideBar.Items.Add(new CustomSideBarItem
            {
                Text = "League of Legends",
                Control = new LolGameControl(),
                Image = Resources.lol,
                AccentColor = Utils.LolAccentColor
            });
            sideBar.Items.Add(new CustomSideBarItem
            {
                Text = "Legends of Runeterra",
                Control = new LorGameControl(),
                Image = Resources.lor,
                AccentColor = Utils.LorAccentColor
            });
            sideBar.Items.Add(new CustomSideBarItem
            {
                Text = "VALORANT",
                Control = new ValorantGameControl(),
                Image = Resources.valorant,
                AccentColor = Utils.ValorantAccentColor
            });
            sideBar.SideBarItemClick += OnSideBarItemClick;
        }

        private void InitializeSettings()
        {
            var settings = Settings.GetSettings();
            if (settings != null)
            {
                _gameInfos = settings.GameInfos;
                txtRiotServicePath.Text = _gameInfos.FirstOrDefault()?.Location;
                cbCloseLauncherOnGameStart.Checked = settings.CloseLauncherOnGameStart;
                _settings = settings;
            }
            else
                GetGameInfos();
        }

        private void GetGameInfos()
        {
            var valorant = _gameLocatorService.GetGameLocation(GameType.Valorant);
            if (valorant != null)
                _gameInfos.Add(valorant);
            var lol = _gameLocatorService.GetGameLocation(GameType.LeagueOfLegends);
            if (lol != null)
                txtRiotServicePath.Text = lol.Location;
                _gameInfos.Add(lol);
            var lor = _gameLocatorService.GetGameLocation(GameType.LegendsOfRuneterra);
            if (lor != null)
                _gameInfos.Add(lor);

            OnBtnSaveClick(null,null);
        }

        #region "Events"
        private void OnSideBarItemClick(object sender, CustomSideBarItem e)
        {
            if (e.Control != null)
            {
                e.Control.Dock = DockStyle.Fill;
                pnlCustomControls.Controls.Clear();
                pnlCustomControls.Visible = true;
                pnlCustomControls.Controls.Add(e.Control);
            }
        }

        private void OnBtnSettingsClick(object sender, System.EventArgs e)
        {
            pnlSettings.Visible = !pnlSettings.Visible;
        }

        private void OnBtnPlayLol(object sender, System.EventArgs e)
        {
            StartGame(_gameInfos.FirstOrDefault(x => x.Type == GameType.LeagueOfLegends));
        }
        private void OnBtnPlayValorant(object sender, System.EventArgs e)
        {
            StartGame(_gameInfos.FirstOrDefault(x => x.Type == GameType.Valorant));
        }

        private void OnBtnPlayLorClick(object sender, System.EventArgs e)
        {
            StartGame(_gameInfos.FirstOrDefault(x => x.Type == GameType.LegendsOfRuneterra));
        }

        private void OnBtnBrowserLolClick(object sender, EventArgs e)
        {
            var gameInfos = OpenFileDialog();
            _gameInfos.Clear();
            _gameInfos = gameInfos;
            txtRiotServicePath.Text = gameInfos.FirstOrDefault()?.Location;
        }
        private void OnBtnSaveClick(object sender, EventArgs e)
        {
            Settings.SaveSettings(new Settings
            {
                GameInfos = _gameInfos,
                CloseLauncherOnGameStart = cbCloseLauncherOnGameStart.Checked
            });
            pnlSettings.Visible = false;
        }

        private void OnBtnCloseClick(object sender, EventArgs e)
        {
            Close();
        }

        private void OnPbGitHubClick(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Cr1TiKa7");
        }

        private void OnPbTwitchClick(object sender, EventArgs e)
        {
            Process.Start("https://www.twitch.tv/cr1tika7");
        }
        #endregion

        #region Helper Functions
        private void StartGame(GameInfo game)
        {
            if (game != null)
            {
                var processInfo = new ProcessStartInfo(game.Location, game.PathAddition);
                Process.Start(processInfo);
                var loadingIndicator = new LoadingIndicator();
                Controls.Add(loadingIndicator);
                loadingIndicator.GameInfo = game;
                loadingIndicator.Location = new Point(342, 179);
                loadingIndicator.BringToFront();
                if (_settings != null && _settings.CloseLauncherOnGameStart)
                    Close();
            }
            else
                MessageBox.Show(this,
                    "The game path couldn't been located. Please select the right location in the settings tab.",
                    "Game location not found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }


        private List<GameInfo> OpenFileDialog()
        {
            var ret = new List<GameInfo>();
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "(RiotClientServices.exe) | RiotClientServices.exe";
                if (ofd.ShowDialog(this) == DialogResult.OK)
                {
                    foreach (var gameType in Enum.GetValues(typeof(GameType)))
                    {
                        var gameInfo = new GameInfo();
                        gameInfo.Location = $"\"{ofd.FileName}\"";

                        switch (gameType)
                        {
                            case GameType.LeagueOfLegends:
                                gameInfo.Name = "League Of Legends";
                                gameInfo.PathAddition = " --launch-product=league_of_legends --launch-patchline=live";
                                break;
                            case GameType.Valorant:
                                gameInfo.Name = "Valorant";
                                gameInfo.PathAddition = " --launch-product=valorant --launch-patchline=live";
                                break;
                            case GameType.LegendsOfRuneterra:
                                gameInfo.Name = "Legends Of Runeterra";
                                gameInfo.PathAddition = " --launch-product=bacon --launch-patchline=live";
                                break;
                        }
                        ret.Add(gameInfo);
                    }
                }
            }

            return ret;
        }

#endregion
      
    }
}
