using WpfApp1.Model;
using Newtonsoft.Json;


namespace WpfApp1.API
{
    public class Summoner_V4 : Api
    {
        public Summoner_V4(string region) : base(region)
        {

        }

        public SummonerDTO GetSummonerByName(string SummonerName)
        {
            string path = "summoner/v4/summoners/by-name/" + SummonerName;

            var response = GET(GetURI(path));
            string content = response.Content.ReadAsStringAsync().Result;

            if(response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<SummonerDTO>(content);
            }
            else
            {
                return null;
            }
        }
    }
}
