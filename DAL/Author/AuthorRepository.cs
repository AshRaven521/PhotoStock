using Microsoft.EntityFrameworkCore;
using PhotoStock.Data;
using PhotoStock.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PhotoStock.DAL
{
    public class AuthorRepository : IAuthorRepository
    {
        private ApplicationDbContext context { get; set; }

        public AuthorRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task DeleteAuthorAsync(int authorId)
        {
            var author = await context.Authors.FindAsync(authorId);
            context.Authors.Remove(author);
            await context.SaveChangesAsync();
        }



        public async Task<Author> GetAuthorByIdAsync(int authorId)
        {
            var author = await context.Authors.FindAsync(authorId);
            return author;
        }

        public async Task<IEnumerable<Author>> GetAuthorsAsync()
        {
            return await context.Authors.ToListAsync();
        }

        public async Task<Author> InsertAuthorAsync(Author author)
        {
            var newAuthor = await context.Authors.AddAsync(author);
            await context.SaveChangesAsync();
            return newAuthor.Entity;
        }

        public async Task SaveAsync()
        {
            await context.SaveChangesAsync();
        }


        /*Позже при надобности добавить 2 модели, как и для фото, а так же осуществить маппинг, как и для фото(зарагестрировать в стартапе,
         создать мапы в MappingProfiles*/
        public async Task UpdateAuthorAsync(Author newAuthor)
        {
            var author = await context.Authors.FindAsync(newAuthor.Id);
            author.Name = newAuthor.Name;
            author.Nickname = newAuthor.Nickname;
            author.Age = newAuthor.Age;

            await context.SaveChangesAsync();
        }
    }
}
