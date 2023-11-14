using System.Text.Json.Serialization;

namespace LuceedAPI.Models
{
    public class LuceedTransactionProductResponse
    {
        [JsonPropertyName("result")]
        public List<ObracunArtikliResult> Result { get; set; }

    }
    public class ObracunArtikliResult
    {
        [JsonPropertyName("obracun_artikli")]
        public List<ObracunArtikli> ObracunArtikli{ get; set; }
    }
}
