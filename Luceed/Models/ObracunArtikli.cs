﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Luceed.Models
{
    public class ObracunArtikli
    {
        [JsonPropertyName("artikl_uid")]
        public string Id { get; set; }
        [JsonPropertyName("naziv_artikla")]
        public string Naziv { get; set; }
        [JsonPropertyName("kolicina")]
        public decimal Kolicina { get; set; }
        [JsonPropertyName("iznos")]
        public decimal Iznos { get; set; }
        [JsonPropertyName("usluga")]
        public string Usluga { get; set; }
    }
}
