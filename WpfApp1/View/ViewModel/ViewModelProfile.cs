

namespace WpfApp1.View.ViewModel
{
    class ViewModelProfile
    {
        private string name;
        private int profileIconId;
        private long summonerLevel;
        private int wins;
        private int losses;

        public string SummonerName { get; set; }
        public string Icon { get; set; }
        public long Level { get; set; }
        public string Tier { get; set; }
        public string Rank { get; set; }
        public string Emblem { get; set; }
        public string Wins { get; set; }
        public string Losses { get; set; }
        public ViewModelProfile(string summonerName, string icon, long level, string tier, string rank, string emblem, string wins, string losses)
        {
            SummonerName = summonerName;
            Icon = icon;
            Level = level;
            Tier = tier;
            Rank = rank;
            Wins = wins;
            Losses = losses;
            
        }

        public ViewModelProfile(string name, int profileIconId, long summonerLevel, string tier, string rank, int wins, int losses)
        {
            this.name = name;
            this.profileIconId = profileIconId;
            this.summonerLevel = summonerLevel;
            Tier = tier;
            Rank = rank;
            this.wins = wins;
            this.losses = losses;
        }
    }
}
