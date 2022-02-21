using PhotoStock.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PhotoStock.DAL
{
    public interface IAuthorRepository
    {
        IEnumerable<Author> GetAuthors();
        Task<Author> GetAuthorByIdAsync(int authorId);
        void InsertAuthorAsync(Author author);
        void DeleteAuthorAsync(int authorId);
        void UpdateAuthor(Author author);
        void SaveAsync();
    }
}
