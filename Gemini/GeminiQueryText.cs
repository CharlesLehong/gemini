using System.Text.Json.Serialization;

namespace Gemini
{
    public class GeminiQueryText
    {
        [JsonPropertyName("text")]
        public string Text { get; set; } = string.Empty;
    }
}
