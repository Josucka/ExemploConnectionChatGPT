using ConnectionChatGPT.BusinessLayer;

namespace ConnectionChatGPT.PresentationLayer
{
    public class Presentation : IPresentation
    {
        private readonly IBusinessLogic _businessLogic;

        public Presentation(IBusinessLogic businessLogic)
        {
            _businessLogic = businessLogic;
        }

        public void ShowData(string data)
        {
            _businessLogic.ProcessData(data);
        }
    }
}
