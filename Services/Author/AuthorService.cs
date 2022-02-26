using PhotoStock.DAL;
using PhotoStock.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PhotoStock.Services
{
    public class AuthorService : IAuthorService
    {
        private IAuthorRepository authorRepository;

        public AuthorService(IAuthorRepository authorRepository)
        {
            this.authorRepository = authorRepository;
        }

        public async Task DeleteAuthorAsync(int authorId)
        {
            await authorRepository.DeleteAuthorAsync(authorId);
        }

        public async Task<Author> GetAuthorByIdAsync(int authorId)
        {
            return await authorRepository.GetAuthorByIdAsync(authorId);
        }

        public async Task<IEnumerable<Author>> GetAuthorsAsync()
        {
            return await authorRepository.GetAuthorsAsync();
        }

        public async Task<Author> InsertAuthorAsync(Author author)
        {
            return await authorRepository.InsertAuthorAsync(author);
        }

        public async Task SaveAsync()
        {
            await authorRepository.SaveAsync();
        }

        public async Task UpdateAuthorAsync(Author author)
        {
            await authorRepository.UpdateAuthorAsync(author);
        }
    }
}
