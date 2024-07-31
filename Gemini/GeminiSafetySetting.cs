using System.Text.Json.Serialization;

namespace Gemini
{
    public class GeminiSafetySetting
    {
        [JsonPropertyName("category")]
        public string Category { get; set; } = string.Empty;

        [JsonPropertyName("threshold")]
        public string Threshold { get; set; } = string.Empty;
    }
}
