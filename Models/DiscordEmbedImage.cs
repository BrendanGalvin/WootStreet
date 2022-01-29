using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WootStreet.Models
{
    public class DiscordEmbedImage
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string url;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int height;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int width;
    }
}
