using System.Collections.Generic;
using System.Data;
using System.IO;
using Newtonsoft.Json;

namespace RiotGamesLauncher.Models
{
    public class Settings
    {
        public List<GameInfo> GameInfos { get; set; } = new List<GameInfo>();
        private const string SETTINGS_PATH = "settings.json";
        public static Settings GetSettings()
        {
            if (!File.Exists(SETTINGS_PATH))
                return null;
            using (var streamReader = new StreamReader(SETTINGS_PATH))
            {
                return JsonConvert.DeserializeObject<Settings>(streamReader.ReadToEnd());
            }
        }

        public static void SaveSettings(Settings settings)
        {
            using (var streamWriter = new StreamWriter(SETTINGS_PATH))
            {
                streamWriter.Write(JsonConvert.SerializeObject(settings));
            }
        }
    }

}
