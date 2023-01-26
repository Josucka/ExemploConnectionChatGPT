using IntegrationWithOpenAI.Services.Interfaces;
using IntegrationWithOpenAI.Services.ServiceModels.OpenAI;
using Microsoft.AspNetCore.Mvc;

namespace IntegrationWithOpenAI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OpenAIController : ControllerBase
    {
        private readonly IOpenAITextService _textService;

        public OpenAIController(IOpenAITextService textService)
        {
            _textService = textService;
        }

        [HttpPost]
        public async Task<IActionResult> CompletePrompt([FromBody] CompletionRequest request)
        {
            var response = await _textService.CompletePrompt(request);
            if(response == null)
                return StatusCode(StatusCodes.Status500InternalServerError);
            
            return Ok(response);
        }

        [HttpPost]
        [Route("Portuguese")]
        public async Task<IActionResult> ReturnPortuguese([FromBody] string text)
        {
            var request = new CompletionRequest
            {
                Model = "text-davinci-003",
                Temperature = 0.7F,
                Prompt = $"Retona este texto em Portugues. Text: {text}",
                MaxTokens = 600
            };

            var response = await _textService.CompletePrompt(request);
            if (response == null)
                return StatusCode(StatusCodes.Status500InternalServerError);

            return Ok(response);
        }
    }
}
