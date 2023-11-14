using System.Text.Json.Serialization;

namespace LuceedAPI.Models
{
    public class Article
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("naziv")]
        public string Naziv { get; set; }
    }
}
