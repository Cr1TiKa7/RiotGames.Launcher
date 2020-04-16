using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using RiotGamesLauncher.Models;
using RiotGamesLauncher.Models.Types;

namespace RiotGamesLauncher.Controls.CustomControls
{
    public partial class SettingsControl : UserControl
    {
        private readonly Settings _settings;
        public SettingsControl(Settings settings)
        {
            _settings = settings;
            InitializeComponent();
            var gameInfo = _settings.GameInfos.FirstOrDefault();
            if (gameInfo != null)
                customTextbox1.Text = gameInfo.Location;

        }

        private void OnBtnSaveClick(object sender, EventArgs e)
        {
            _settings.CloseLauncherOnGameStart = cbCloseLauncherOnGameStart.Checked;
            Settings.SaveSettings(_settings);
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

        private void OnBtnSettingsClick(object sender, EventArgs e)
        {
            var gameInfos = OpenFileDialog();
            _settings.GameInfos = gameInfos;
            customControlBox1.Text = _settings.GameInfos.FirstOrDefault()?.Location;
        }
    }
}
