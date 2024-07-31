using System.Dynamic;
using System.Text;
using System.Text.Json;

namespace Gemini
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //var x = await UploadImageAsync("C:\\Users\\CharlesLehong\\Downloads\\ilovepdf_pages-to-jpg\\Telkom_page-0002.jpg");

            //// https://generativelanguage.googleapis.com/v1beta/files/bckq5886t39l


            var files = new List<GeminiInputFile>()
            {
                new GeminiInputFile()
                {
                    MineType = "image/jpeg",
                    FileUri = "https://generativelanguage.googleapis.com/v1beta/files/qm8v4lxazl6w"
                },
                new GeminiInputFile()
                {
                    MineType = "image/jpeg",
                    FileUri = "https://generativelanguage.googleapis.com/v1beta/files/r9it8hpt4v6t"
                }
            };

            var query = "Extract lessor, lessee and erf number. Return results as a json object";
            await QueryGeminiAsync(files, query);
        }






        private static async Task<GeminiOutputFile> UploadImageAsync(string path)
        {
            using var client = new HttpClient();
            var url = "https://generativelanguage.googleapis.com/upload/v1beta/files?uploadType=media&key=AIzaSyB_MkEoVg3guiV6kXnNW484mIyVB-NvlTc";
            var x = File.ReadAllBytes(path);
            var response = await client.PostAsync(url, new ByteArrayContent(x));
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();

            var y = JsonSerializer.Deserialize<GeminiFileUploadResponse>(responseBody);
            return y.File;
        }



        private static async Task QueryGeminiAsync(List<GeminiInputFile> files, string query)
        {
            var b = new GeminiQueryRequest()
            {
                Contents = new List<GeminiContent>(),
                SafetySettings = new List<GeminiSafetySetting>()
                {
                    new GeminiSafetySetting()
                    {
                        Category = "HARM_CATEGORY_SEXUALLY_EXPLICIT",
                        Threshold = "BLOCK_NONE"
                    },
                    new GeminiSafetySetting()
                    {
                        Category = "HARM_CATEGORY_HATE_SPEECH",
                        Threshold = "BLOCK_NONE"
                    },
                    new GeminiSafetySetting()
                    {
                        Category = "HARM_CATEGORY_HARASSMENT",
                        Threshold = "BLOCK_NONE"
                    },
                    new GeminiSafetySetting()
                    {
                        Category = "HARM_CATEGORY_DANGEROUS_CONTENT",
                        Threshold = "BLOCK_NONE"
                    }
                }
            };

            var content = new GeminiContent()
            {
                Parts = new List<dynamic>()
            };

            content.Parts.Add(new GeminiQueryText()
            {
                Text = query,
            });

            foreach (var file in files) 
            {
                content.Parts.Add(new GeminiFileDataPart()
                {
                    FileData = file
                });
            }

            b.Contents.Add(content);


            using var client = new HttpClient();
            var url = "https://generativelanguage.googleapis.com/v1beta/models/gemini-1.5-pro:generateContent?key=AIzaSyB_MkEoVg3guiV6kXnNW484mIyVB-NvlTc";

            //client.DefaultRequestHeaders.Add("Content-Type", "application/json");


            var response = await client.PostAsync(url, new StringContent(JsonSerializer.Serialize(b), Encoding.UTF8, "application/json"));

            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();

            var y = JsonSerializer.Deserialize<dynamic>(responseBody);
        }
    }
}
