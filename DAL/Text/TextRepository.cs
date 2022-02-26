using Microsoft.EntityFrameworkCore;
using PhotoStock.Data;
using PhotoStock.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PhotoStock.DAL
{
    public class TextRepository : ITextRepository
    {
        private ApplicationDbContext context;

        public TextRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task DeleteTextAsync(int textId)
        {
            var text = await context.Texts.FindAsync(textId);
            context.Texts.Remove(text);
            await context.SaveChangesAsync();
        }

        public async Task<Text> GetTextByIdAsync(int textId)
        {
            var text = await context.Texts.FindAsync(textId);
            return text;
        }

        public async Task<IEnumerable<Text>> GetTextsAsync()
        {
            return await context.Texts.ToListAsync();
        }

        public async Task<Text> InsertTextAsync(Text text)
        {

            var newText = await context.Texts.AddAsync(text);
            await context.SaveChangesAsync();
            return newText.Entity;
        }

        public async Task SaveAsync()
        {
            await context.SaveChangesAsync();
        }

        /*Позже при надобности добавить 2 модели, как и для фото, а так же осуществить маппинг, как и для фото(зарагестрировать в стартапе,
         создать мапы в MappingProfiles*/
        public async Task UpdateTextAsync(Text newText)
        {
            var text = await context.Texts.FindAsync(newText.Id);
            //Не нужно присваивать Id, CreationDate, Author, AuthorForeignKey,  т.к. сработает маппинг
            text.Name = newText.Name;
            text.PurchaseAmount = newText.PurchaseAmount;
            text.Content = newText.Content;
            text.Cost = newText.Cost;
            text.Demension = newText.Demension;

            await context.SaveChangesAsync();
        }
    }
}
