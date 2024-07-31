using System.Text.Json.Serialization;

namespace Gemini
{
    internal class GeminiFileUploadResponse
    {
        [JsonPropertyName("file")]
        public GeminiOutputFile File { get; set; } = new GeminiOutputFile();
    }
}
