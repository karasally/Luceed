using System.Text.Json.Serialization;

namespace LuceedAPI.Models
{
    public class LuceedArticleResponse
    {
        [JsonPropertyName("result")]
        public List<Result> Result { get; set; }
    }

    public class Result
    {
        [JsonPropertyName("artikli")]
        public List<Article> Artikli { get; set; }
    }
}
