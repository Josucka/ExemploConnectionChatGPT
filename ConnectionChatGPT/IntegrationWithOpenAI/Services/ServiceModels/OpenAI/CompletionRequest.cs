using Newtonsoft.Json;

namespace IntegrationWithOpenAI.Services.ServiceModels.OpenAI
{
    public class CompletionRequest
    {
        [JsonProperty("model")]
        public string Model { get; set; }
        [JsonProperty("prompt")]
        public string Prompt { get; set; }
        [JsonProperty("temperature")]
        public float Temperature { get; set; }
        [JsonProperty("max_tokens")]
        public int MaxTokens { get; set; }
    }
}
