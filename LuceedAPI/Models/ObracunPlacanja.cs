using System.Text.Json.Serialization;

namespace LuceedAPI.Models
{
    public class ObracunPlacanja
    {
        [JsonPropertyName("vrste_placanja_uid")]
        public string Id { get; set; }
        [JsonPropertyName("naziv")]
        public string Naziv { get; set; }
        [JsonPropertyName("iznos")]
        public decimal Iznos { get; set; }
        [JsonPropertyName("nadgrupa_placanja_uid")]
        public string NadgrupaPlacanjaId { get; set; }
        [JsonPropertyName("nadgrupa_placanja_naziv")]
        public string NadgrupaPlacanjaNaziv { get; set; }
    }
}
