using System;
using System.Collections.Generic;
using System.Linq;
using WpfApp1.API;
using WpfApp1.Utils;

namespace WpfApp1.Controller
{
    public class ControllerMain
    {
        public bool GetSummoner(string region, string summonerName)
        {
            Summoner_V4 summoner_V4 = new Summoner_V4(Constants.Region);

            var summoner = summoner_V4.GetSummonerByName(summonerName);

            Constants.Summoner = summoner;

            return summoner != null;
        }
    }
}
