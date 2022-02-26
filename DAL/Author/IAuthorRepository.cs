using PhotoStock.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PhotoStock.DAL
{
    public interface IAuthorRepository
    {
        Task<IEnumerable<Author>> GetAuthorsAsync();
        Task<Author> GetAuthorByIdAsync(int authorId);
        Task<Author> InsertAuthorAsync(Author author);
        Task DeleteAuthorAsync(int authorId);
        Task UpdateAuthorAsync(Author author);
        Task SaveAsync();
    }
}
