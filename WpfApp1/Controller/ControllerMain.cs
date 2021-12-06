﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.API;

namespace WpfApp1.Controller
{
    public class ControllerMain
    {
        public bool GetSummoner(string region, string summonerName)
        {
            Summoner_V4 summoner_V4 = new Summoner_V4(region);

            var summoner = summoner_V4.GetSummonerByName(summonerName);

            return summoner != null;
        }
    }
}