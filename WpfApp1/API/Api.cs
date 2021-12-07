using System.IO;
using System.Net.Http;

namespace WpfApp1.API
{
    public class Api
    {
        private string key { get; set; }

        private string Region { get; set; }

        public Api(string region)
        {
            Region = region;
            key = GetKey("API/Key.txt");
        }

       protected HttpResponseMessage GET(string URL)
       {
           using (HttpClient client = new HttpClient())
           {
               var result = client.GetAsync(URL);
               result.Wait();
      
               return result.Result;
           }
       }
        protected string GetURI(string path)
        {
            return "https://" + Region + ".api.riotgame.com/lol/" + path + "?api_key=" + key;
        }

        public string GetKey(string path)
        {
            StreamReader sr = new StreamReader(path);
            return sr.ReadToEnd();
        }
    }
}
