using IntegrationWithOpenAI.Services.ServiceModels.OpenAI;

namespace IntegrationWithOpenAI.Services.Interfaces
{
    public interface IOpenAITextService
    {
        Task<CompletionResponse> CompletePrompt(CompletionRequest request);
    }
}
