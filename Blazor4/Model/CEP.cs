﻿using System.Text.Json.Serialization;
#nullable disable
namespace Blazor4.Model
{
    public class CEP
    {
        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("district")]
        public string District { get; set; }

        [JsonPropertyName("address")]
        public string Address { get; set; }

        [JsonPropertyName("status")]
        public int Status { get; set; }

        [JsonPropertyName("ok")]
        public bool Ok { get; set; }

        [JsonPropertyName("statusText")]
        public string StatusText { get; set; }


    }
}
