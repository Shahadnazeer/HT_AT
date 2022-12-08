using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT_AT.Models
{
    public class AddressList
    {
        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("suite")]
        public string Suite { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        [JsonProperty("geo")]
        public GeoList Geo { get; set; }
    }
}
