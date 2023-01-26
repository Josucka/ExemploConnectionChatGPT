namespace IntegrationWithOpenAI.config
{
    public static class OpenAIConfig
    {
        public static string AuthSecret = Environment.GetEnvironmentVariable("openAISecret") ?? throw new NullReferenceException(nameof(AuthSecret));
        public static string BaseAddress = "https://api.openai.com/v1/";
    }
}
