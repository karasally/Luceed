using System.Text.Json.Serialization;

namespace LuceedAPI.Models
{
    public class LuceedTransactionPaymentTypeResponse
    {
        [JsonPropertyName("result")]
        public List<ObracunPlacanjaResult> Result { get; set; }
    }

    public class ObracunPlacanjaResult
    {
        [JsonPropertyName("obracun_placanja")]
        public List<ObracunPlacanja> ObracunPlacanja { get; set; }
    }
}
