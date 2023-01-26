using IntegrationWithOpenAI.Services.Interfaces;
using IntegrationWithOpenAI.Services.ServiceModels.OpenAI;
using Newtonsoft.Json;
using System.Text;

namespace IntegrationWithOpenAI.Services
{
    public class OpenAITextService : BaseOpenAIService, IOpenAITextService
    {
        public OpenAITextService(HttpClient httpClient) : base(httpClient)
        {
        }

        public async Task<CompletionResponse> CompletePrompt(CompletionRequest request)
        {
            string json = JsonConvert.SerializeObject(request);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _httpClient.PostAsync("completions", content);
            string responseContent = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<CompletionResponse>(responseContent);
        }
    }
}
