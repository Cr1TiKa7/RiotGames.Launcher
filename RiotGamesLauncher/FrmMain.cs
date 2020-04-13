using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using RiotGamesLauncher.Models;
using RiotGamesLauncher.Models.Types;
using RiotGamesLauncher.Services;

namespace RiotGamesLauncher
{
    public partial class FrmMain : Form
    {
        private GameLocatorService _gameLocatorService = new GameLocatorService();
        private List<GameInfo> _gameInfos = new List<GameInfo>();
        public FrmMain()
        {
            InitializeComponent();
            InitializeSettings();
        }

        private void InitializeSettings()
        {
            var settings = Settings.GetSettings();
            if (settings != null)
            {
                _gameInfos = settings.GameInfos;
                txtRiotServicePath.Text = _gameInfos.FirstOrDefault()?.Location;
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

        private void OnBtnSettingsClick(object sender, System.EventArgs e)
        {
            pnlSettings.Visible = !pnlSettings.Visible;
        }

        #region "Play Buttons"  
        private void OnBtnPlayLol(object sender, System.EventArgs e)
        {

        }
        private void OnBtnPlayValorant(object sender, System.EventArgs e)
        {

        }

        private void OnBtnPlayLorClick(object sender, System.EventArgs e)
        {

        }

        private void StartGame(GameInfo game)
        {
            if (game != null)
            {
                var processInfo = new ProcessStartInfo(game.Location, game.PathAddition);
                Process.Start(processInfo);
            }
            else
                MessageBox.Show(this,
                    "The game path couldn't been located. Please select the right location in the settings tab.",
                    "Game location not found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }


        #endregion

        private void OnBtnBrowserLolClick(object sender, EventArgs e)
        {
            var gameInfos = OpenFileDialog();
            _gameInfos.Clear();
            _gameInfos = gameInfos;
            txtRiotServicePath.Text = gameInfos.FirstOrDefault()?.Location;
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

        private void OnBtnSaveClick(object sender, EventArgs e)
        {
            Settings.SaveSettings(new Settings
            {
                GameInfos = _gameInfos
            });
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
    }
}
