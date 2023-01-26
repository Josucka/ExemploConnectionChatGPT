using Newtonsoft.Json;

namespace IntegrationWithOpenAI.Services.ServiceModels.OpenAI
{
    public class Choice
    {
        [JsonProperty("text")]
        public string Text { get; set; }
        [JsonProperty("index")]
        public int Index { get; set; }
        [JsonProperty("log_probs")]
        public object Logprobs { get; set; }
        [JsonProperty("finish_reason")]
        public string Finish_reason { get; set; }
    }
}
