using RiotGamesLauncher.Models.Types;

namespace RiotGamesLauncher.Models
{
    public class GameInfo
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string PathAddition { get; set; }
        public GameType Type { get; set; }
    }
}
