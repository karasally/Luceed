using System.Text.Json.Serialization;

namespace LuceedAPI.Models
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
