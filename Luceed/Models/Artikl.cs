using System.Text.Json.Serialization;

namespace Luceed.Models
{
    public class Artikl
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("naziv")]
        public string Naziv { get; set; }
    }
}
