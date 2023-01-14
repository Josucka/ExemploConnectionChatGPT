namespace ConnectionChatGPT.DataAccessLayer
{
    public class Chatbot : IChatbot
    {
        private readonly OpenAIClient _client;

        public Chatbot(string apikey)
        {
            _client = new OpenAIClient(apikey);
            _client.Model = "text-davinci-003";
            _client.Temperature = 0.5;
        }
    
        public async Task<string> GetResponse(string prompt)
        {
            return await _client.Completion(prompt);
        }
    }
}
