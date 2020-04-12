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
                txtValorant.Text = _gameInfos.FirstOrDefault(x => x.Type == GameType.Valorant)?.Location;
                txtLol.Text = _gameInfos.FirstOrDefault(x => x.Type == GameType.LeagueOfLegends)?.Location;
                txtLor.Text = _gameInfos.FirstOrDefault(x => x.Type == GameType.LegendsOfRuneterra)?.Location;
            }
            else
                GetGameInfos();
        }

        private void GetGameInfos()
        {
            var valorant = _gameLocatorService.GetGameLocation(GameType.Valorant);
            if (valorant != null)
            {
                txtValorant.Text = valorant.Location;
                _gameInfos.Add(valorant);
            }
            var lol = _gameLocatorService.GetGameLocation(GameType.LeagueOfLegends);
            if (lol != null)
            {
                txtLol.Text = lol.Location;
                _gameInfos.Add(lol);
            }
            var lor = _gameLocatorService.GetGameLocation(GameType.LegendsOfRuneterra);
            if (lor != null)
            {
                txtLor.Text = lor.Location;
                _gameInfos.Add(lor);
            }
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

        private void OnBtnBrowserLolClick(object sender, System.EventArgs e)
        {
            var lolGame = OpenFileDialog(GameType.LeagueOfLegends);
            var existing = _gameInfos.FirstOrDefault(x => x.Type == GameType.LeagueOfLegends);
            if (existing != null)
            {
                _gameInfos.Remove(existing);
            }

            _gameInfos.Add(lolGame);
            txtLol.Text = lolGame.Location;
        }

        private void OnBtnBrowseValorantClick(object sender, System.EventArgs e)
        {
            var valorantGame = OpenFileDialog(GameType.Valorant);
            var existing = _gameInfos.FirstOrDefault(x => x.Type == GameType.Valorant);
            if (existing != null)
            {
                _gameInfos.Remove(existing);
            }

            _gameInfos.Add(valorantGame);
            txtValorant.Text = valorantGame.Location;
        }

        private void OnBtnBrowseLegendsOfRuneterra(object sender, System.EventArgs e)
        {
            var lorGame = OpenFileDialog(GameType.LegendsOfRuneterra);
            var existing = _gameInfos.FirstOrDefault(x => x.Type == GameType.LegendsOfRuneterra);
            if (existing != null)
            {
                _gameInfos.Remove(existing);
            }

            _gameInfos.Add(lorGame);
            txtLor.Text = lorGame.Location;
        }

        private GameInfo OpenFileDialog(GameType gameType)
        {
            GameInfo ret = null;
            using (var ofd = new OpenFileDialog()) 
            {
                if (ofd.ShowDialog(this) == DialogResult.OK)
                {
                    ret = new GameInfo();
                    ret.Location = ofd.FileName;

                    switch (gameType)
                    {
                        case GameType.LeagueOfLegends:
                            ret.Name = "League Of Legends";
                            ret.PathAddition = " --launch-product=league_of_legends --launch-patchline=live";
                            break;
                        case GameType.Valorant:
                            ret.Name = "Valorant";
                            ret.PathAddition = " --launch-product=valorant --launch-patchline=live";
                            break;
                        case GameType.LegendsOfRuneterra:
                            ret.Name = "Legends Of Runeterra";
                            ret.PathAddition = " --launch-product=bacon --launch-patchline=live";
                            break;
                    }
                }
            }

            return ret;
        }

        private void OnBtnSaveClick(object sender, System.EventArgs e)
        {
            Settings.SaveSettings(new Settings
            {
                GameInfos = _gameInfos
            });
        }
    }
}
