using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Gemini
{
    public class GeminiQueryRequest
    {
        [JsonPropertyName("contents")]
        public List<GeminiContent> Contents { get; set; } = new List<GeminiContent>();

        [JsonPropertyName("safetySettings")]
        public List<GeminiSafetySetting> SafetySettings { get; set; } = new List<GeminiSafetySetting>();
    }
}
