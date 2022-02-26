using Microsoft.AspNetCore.Mvc;
using PhotoStock.Models;
using PhotoStock.Services;
using System.Threading.Tasks;


namespace PhotoStock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TextController : ControllerBase
    {
        private ITextService textService;

        public TextController(ITextService textService)
        {
            this.textService = textService;
        }

        [HttpPost("create-text")]
        public async Task<IActionResult> CreateText(Text text)
        {
            if (text is null)
            {
                return BadRequest();
            }
            await textService.InsertTextAsync(text);
            await textService.SaveAsync();

            return Ok();
        }

        [HttpGet("text-list")]
        public async Task<IActionResult> GetAll()
        {
            var texts = await textService.GetTextsAsync();

            return Ok(texts);
        }
    }
}
