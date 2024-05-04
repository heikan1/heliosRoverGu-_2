using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace heliosRoverGuı_2
{
    internal class ThingSpeakPorcessor
    {
        public static async Task<Feeds> LoadThingSpeak()
        {
            string url = "https://api.thingspeak.com/channels/2525662/feeds.json?api_key=JWKKGVJ9HXC1OI6J&results=2";

            using(HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    ThingSpeakModel result = await response.Content.ReadFromJsonAsync<ThingSpeakModel>();
                    return result.Feeds;
                }
                else{
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
