using ConnectionChatGPT.BusinessLayer;
using ConnectionChatGPT.DataAccessLayer;
using ConnectionChatGPT.PresentationLayer;

string apiKey = "My KeyApi";


IChatbot chatbot = new Chatbot(apiKey);
IBusinessLogic businessLogic = new BusinessLogic(chatbot);
IPresentation presentation = new Presentation(businessLogic);

Console.WriteLine("Entre a prompt(to finish type 'exist'):");

while (true)
{
    Console.Write("-> ");
    string prompt = Console.ReadLine();
    if (prompt == "exit")
        break;

    presentation.ShowData(prompt);
}