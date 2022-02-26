using Microsoft.AspNetCore.Mvc;
using PhotoStock.Services;
using System.Threading.Tasks;

namespace PhotoStock.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController : ControllerBase
    {
        private IAuthorService authorService;

        public AuthorController(IAuthorService authorService)
        {
            this.authorService = authorService;
        }


        [HttpGet("author-list")]
        public async Task<IActionResult> GetAll()
        {
            var authors = await authorService.GetAuthorsAsync();

            return Ok(authors);
        }
    }
}
