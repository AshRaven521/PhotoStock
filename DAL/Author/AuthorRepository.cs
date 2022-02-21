using PhotoStock.Data;
using PhotoStock.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoStock.DAL
{
    public class AuthorRepository : IAuthorRepository
    {
        public ApplicationDbContext Context { get; set; }

        public AuthorRepository(ApplicationDbContext context)
        {
            Context = context;
        }

        public async void DeleteAuthorAsync(int authorId)
        {
            var author = await Context.Authors.FindAsync(authorId);
            Context.Authors.Remove(author);
        }

      

        public async Task<Author> GetAuthorByIdAsync(int authorId)
        {
            var author = await Context.Authors.FindAsync(authorId);
            return author;
        }

        public IEnumerable<Author> GetAuthors()
        {
            return Context.Authors.ToList();
        }

        public async void InsertAuthorAsync(Author author)
        {
            await Context.Authors.AddAsync(author);
        }

        public async void SaveAsync()
        {
            await Context.SaveChangesAsync();
        }

        public void UpdateAuthor(Author author)
        {
            Context.Entry(author).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}
