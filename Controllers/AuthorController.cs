using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PhotoStock.DAL;
using PhotoStock.Data;
using PhotoStock.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PhotoStock.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController : ControllerBase
    {
        private IAuthorRepository authorRepository; 

        public AuthorController(IAuthorRepository authorRepository)
        {
            this.authorRepository = authorRepository;
        }
        

        /*[HttpPost]
        public async Task<IActionResult> SaveAuthors()
        {
            var author1 = new Author { Name = "Tom", Age = 33 };
            var author2 = new Author { Name = "Alice", Age = 26 };

            //await context.Authors.AddRangeAsync(author1, author2);

            //await context.SaveChangesAsync();


            //var authors = await context.Authors.ToListAsync();
            //return Ok(authors);
            return Ok();
        }*/

        [HttpGet]
        public IEnumerable<Author> GetAll()
        {
            return authorRepository.GetAuthors();
        }
    }
}
