using System.Text.Json.Serialization;

#nullable disable

namespace Blazor4.Model
{
    public class Countries
    {

        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("topLevelDomain")]
        public List<string> topLevelDomain { get; set; }

        [JsonPropertyName("alpha2Code")]
        public string alpha2Code { get; set; }

        [JsonPropertyName("alpha3Code")]
        public string alpha3Code { get; set; }

        [JsonPropertyName("callingCodes")]
        public List<string> callingCodes { get; set; }

        [JsonPropertyName("capital")]
        public string capital { get; set; }

        [JsonPropertyName("altSpellings")]
        public List<string> altSpellings { get; set; }

        [JsonPropertyName("region")]
        public string region { get; set; }

    }
}
