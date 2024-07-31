using System.Text.Json.Serialization;

namespace Gemini
{
    public class GeminiContent
    {
        [JsonPropertyName("parts")]
        public List<dynamic> Parts { get; set; } = new List<dynamic>();
    }
}
