using Newtonsoft.Json;
using System.Text;

namespace ConnectionChatGPT.DataAccessLayer
{
    internal class OpenAIClient
    {
        private string _apikey;

        public OpenAIClient(string apikey)
        {
            _apikey = apikey;
        }

        public string Model { get; set; }
        public double Temperature { get; set; }

        public async Task<string> Completion(string prompt)
        {
            int maxTokens = 1024;
            string requestUrl = $"https://api.openai.com/v1/completions";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {_apikey}");

            var requestJson = new
            {
                prompt = prompt,
                max_tokens = maxTokens,
                temperature = Temperature,
                model = Model
            };

            StringContent content = new StringContent(JsonConvert.SerializeObject(requestJson), Encoding.UTF8, "application/json");

            HttpResponseMessage response = client.PostAsync(requestUrl, content).Result;
            string responseJson = response.Content.ReadAsStringAsync().Result;

            dynamic responseObjct = JsonConvert.DeserializeObject(responseJson);
            string completedText = responseObjct.choice[0].text;

            return await Task<string>.FromResult(completedText);
        }
    }
}
