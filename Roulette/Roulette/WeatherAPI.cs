using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{

    class WeatherAPI
    {
        public static async Task<int[]> GetRealWeather()
        {
            int[] results = new int[3];

            string apiUrl = "http://api.openweathermap.org/data/2.5/weather?id=4473083";
            string apiKey = "794a93b9bae9ddd50fb56409fa4291d2";

            using (HttpClient client = new HttpClient())
            {
                string repUrl = apiUrl + "&APPID=" + apiKey;

                HttpResponseMessage response = await client.GetAsync(repUrl);
                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    RealWeather.RootObject rootResult = JsonConvert.DeserializeObject<RealWeather.RootObject>(result);

                    results[0] = rootResult.clouds.all;
                    results[1] = Convert.ToInt32(rootResult.main.temp);
                    results[2] = rootResult.main.humidity;
                    return results;
                }
                else
                {
                    return results;
                }
            }

        }

    }
}

