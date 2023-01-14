using ConnectionChatGPT.DataAccessLayer;

namespace ConnectionChatGPT.BusinessLayer
{
    public class BusinessLogic : IBusinessLogic
    {
        public readonly IChatbot _chatbot;

        public BusinessLogic(IChatbot chatbot)
        {
            _chatbot = chatbot;
        }

        public void ProcessData(string data)
        {
            string response = _chatbot.GetResponse(data).Result;
            Console.WriteLine($"Chatbot response: {response}");
        }
    }
}
