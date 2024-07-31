using System.Text.Json.Serialization;

namespace Gemini
{
    public class GeminiFileDataPart
    {
        [JsonPropertyName("fileData")]
        public GeminiInputFile FileData { get; set; } = new GeminiInputFile();
    }
}
