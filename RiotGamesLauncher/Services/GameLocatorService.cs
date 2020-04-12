using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Win32;
using RiotGamesLauncher.Models;
using RiotGamesLauncher.Models.Types;

namespace RiotGamesLauncher.Services
{
    public class GameLocatorService
    { 
        private Regex _pathRegex = new Regex("\\\"([^\\\"]*)\\\"");
        public GameInfo GetGameLocation(GameType gameType)
        {
            GameInfo ret = null;
            try
            {
                RegistryKey key = null;
                var gamePathAddition = "";
                switch (gameType)
                {
                    case GameType.LeagueOfLegends:
                        key = Registry.CurrentUser.OpenSubKey(
                            "Software\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\Riot Game league_of_legends.live");
                        gamePathAddition = " --launch-product=league_of_legends --launch-patchline=live";
                        break;
                    case GameType.Valorant:
                        key = Registry.CurrentUser.OpenSubKey(
                            "Software\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\Riot Game valorant.live");
                        gamePathAddition = " --launch-product=valorant --launch-patchline=live";
                        break;
                    case GameType.LegendsOfRuneterra:
                        key = Registry.CurrentUser.OpenSubKey(
                            "Software\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\Riot Game bacon.live");
                        gamePathAddition = " --launch-product=bacon --launch-patchline=live";
                        break;
                }

                if (key == null)
                    return null;

                var name = (string)key.GetValue("DisplayName");
                var path = (string) key.GetValue("UninstallString");


                var match = _pathRegex.Match(path);

                if (match.Success)
                    path = match.Groups[0].Value;

                ret = new GameInfo
                {
                    Location =path,
                    Name = name,
                    Type = gameType,
                    PathAddition = gamePathAddition
                };

            }
            catch (Exception ex)
            {
                return null;
            }

            return ret;
        }

    }

}
