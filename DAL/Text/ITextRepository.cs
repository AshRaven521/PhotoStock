using PhotoStock.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PhotoStock.DAL
{
    public interface ITextRepository
    {
        Task<IEnumerable<Text>> GetTextsAsync();
        Task<Text> GetTextByIdAsync(int textId);
        Task DeleteTextAsync(int textId);
        Task<Text> InsertTextAsync(Text text);
        Task SaveAsync();
        Task UpdateTextAsync(Text text);
    }
}
