using PhotoStock.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PhotoStock.Services
{
    public interface IAuthorService
    {
        Task<IEnumerable<Author>> GetAuthorsAsync();
        Task<Author> GetAuthorByIdAsync(int authorId);
        Task<Author> InsertAuthorAsync(Author author);
        Task DeleteAuthorAsync(int authorId);
        Task UpdateAuthorAsync(Author author);
        Task SaveAsync();
    }
}
