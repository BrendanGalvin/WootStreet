using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WootStreet.Models
{
    public class DiscordMessage
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string username;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string avatar_url;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string content;
    }
}
