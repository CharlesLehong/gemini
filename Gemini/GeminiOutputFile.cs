using System.Text.Json.Serialization;

namespace Gemini
{
    public class GeminiOutputFile
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("mimeType")]
        public string MimeType { get; set; } = string.Empty;

        [JsonPropertyName("sizeBytes")]
        public string SizeBytes { get; set; } = string.Empty;

        [JsonPropertyName("createTime")]
        public string CreateTime { get; set; } = string.Empty;

        [JsonPropertyName("updateTime")]
        public string UpdateTime { get; set; } = string.Empty;

        [JsonPropertyName("expirationTime")]
        public string ExpirationTime { get; set; } = string.Empty;

        [JsonPropertyName("sha256Hash")]
        public string Sha256Hash { get; set; } = string.Empty;

        [JsonPropertyName("uri")]
        public string Uri { get; set; } = string.Empty;

        [JsonPropertyName("state")]
        public string State { get; set; } = string.Empty;
    }
}
