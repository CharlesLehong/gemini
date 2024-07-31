using System.Text.Json.Serialization;

namespace Gemini
{
    public class GeminiInputFile
    {
        [JsonPropertyName("mime_type")]
        public string MineType { get; set; } = string.Empty;

        [JsonPropertyName("fileUri")]
        public string FileUri { get; set; } = string.Empty;
    }
}
