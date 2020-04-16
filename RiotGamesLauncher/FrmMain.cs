using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using RiotGamesLauncher.Controls;
using RiotGamesLauncher.Controls.CustomControls;
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
        private Settings _settings = new Settings();
        public FrmMain()
        {
            InitializeComponent();
            InitializeSettings();
            InitializeSideBar();
        }

        private void InitializeSideBar()
        {
            var lol = _settings.GameInfos.FirstOrDefault(x => x.Type == GameType.LeagueOfLegends);
            var lor = _settings.GameInfos.FirstOrDefault(x => x.Type == GameType.LegendsOfRuneterra);
            var valorant = _settings.GameInfos.FirstOrDefault(x => x.Type == GameType.Valorant);
            if (lol != null)
                sideBar.Items.Add(new CustomSideBarItem
                {
                    Text = "League of Legends",
                    Control = new LolGameControl(_settings, lol),
                    Image = Resources.lol,
                    AccentColor = Utils.LolAccentColor
                });
            if (lor != null)
                sideBar.Items.Add(new CustomSideBarItem
                {
                    Text = "Legends of Runeterra",
                    Control = new LorGameControl(_settings,lor),
                    Image = Resources.lor,
                    AccentColor = Utils.LorAccentColor
                });
            if (valorant != null)
                sideBar.Items.Add(new CustomSideBarItem
                {
                    Text = "VALORANT",
                    Control = new ValorantGameControl(_settings,valorant),
                    Image = Resources.valorant,
                    AccentColor = Utils.ValorantAccentColor
                }); 
            sideBar.Items.Add(new CustomSideBarItem
                {
                    Text = "Settings",
                    Control = new SettingsControl(_settings),
                    Image = Resources.baseline_settings_white_48dp,
                    AccentColor = Color.White
                });
            sideBar.SideBarItemClick += OnSideBarItemClick;
        }

        private void InitializeSettings()
        {
            var settings = Settings.GetSettings();
            if (settings != null)
                _settings = settings;
            else
                GetGameInfos();
        }

        private void GetGameInfos()
        {
            _settings.GameInfos = new List<GameInfo>();
            var valorant = _gameLocatorService.GetGameLocation(GameType.Valorant);
            if (valorant != null)
                _settings.GameInfos.Add(valorant);
            var lol = _gameLocatorService.GetGameLocation(GameType.LeagueOfLegends);
            if (lol != null)
                _settings.GameInfos.Add(lol);
            var lor = _gameLocatorService.GetGameLocation(GameType.LegendsOfRuneterra);
            if (lor != null)
                _settings.GameInfos.Add(lor);
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

        private void OnBtnBrowserLolClick(object sender, EventArgs e)
        {
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
    }
}
