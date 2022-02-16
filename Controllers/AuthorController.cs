using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        private ApplicationDbContext context;

        public AuthorController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpPost]
        public async Task<IActionResult> SaveAuthors()
        {
            var author1 = new Author { Name = "Tom", Age = 33 };
            var author2 = new Author { Name = "Alice", Age = 26 };

            await context.Authors.AddRangeAsync(author1, author2);
            await context.SaveChangesAsync();


            var authors = await context.Authors.ToListAsync();
            return Ok(authors);
        }
    }
}
