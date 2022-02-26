using PhotoStock.DAL;
using PhotoStock.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PhotoStock.Services
{
    public class TextService : ITextService
    {
        private ITextRepository textRepository;

        public TextService(ITextRepository textRepository)
        {
            this.textRepository = textRepository;
        }

        public async Task DeleteTextAsync(int textId)
        {
            await textRepository.DeleteTextAsync(textId);
        }

        public async Task<Text> GetTextByIdAsync(int textId)
        {
            return await textRepository.GetTextByIdAsync(textId);
        }

        public async Task<IEnumerable<Text>> GetTextsAsync()
        {
            return await textRepository.GetTextsAsync();
        }

        public async Task<Text> InsertTextAsync(Text text)
        {
            return await textRepository.InsertTextAsync(text);
        }

        public async Task SaveAsync()
        {
            await textRepository.SaveAsync();
        }

        public async Task UpdateTextAsync(Text text)
        {
            await textRepository.UpdateTextAsync(text);
        }
    }
}
