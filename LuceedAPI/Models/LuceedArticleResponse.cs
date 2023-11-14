using System.Text.Json.Serialization;

namespace LuceedAPI.Models
{
    public class LuceedArticleResponse
    {
        [JsonPropertyName("result")]
        public List<ArticleResult> Result { get; set; }
    }

    public class ArticleResult
    {
        [JsonPropertyName("artikli")]
        public List<Article> Artikli { get; set; }
    }
}
