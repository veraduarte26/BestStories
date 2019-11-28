using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;

namespace BestStories.Utils
{
    public class SerialializeJson
    {

        public static T SerializeJson<T>(string url) where T : new()
        {
            using (var w = new WebClient())
            {
                var json_data = string.Empty;
                
                try
                {
                    json_data = w.DownloadString(url);
                }
                catch (Exception) { }                
                return !string.IsNullOrEmpty(json_data) ? JsonConvert.DeserializeObject<T>(json_data) : new T();
            }
        }
    }
        
}
