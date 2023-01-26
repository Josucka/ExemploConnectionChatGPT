using Newtonsoft.Json;

namespace IntegrationWithOpenAI.Services.ServiceModels.OpenAI
{
    public class Usage
    {
        [JsonProperty("prompt_tokens")]
        public double PromptTokens { get; set; }
        [JsonProperty("completion_tokens")]
        public double CompletionTokens { get; set; }
        [JsonProperty("total_tokens")]
        public double TotalTokens { get; set; }
    }
}
