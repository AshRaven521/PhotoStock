using PhotoStock.Data;
using PhotoStock.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public async void DeleteTextAsync(int textId)
        {
            var text = await context.Texts.FindAsync(textId);
            context.Texts.Remove(text);
        }

        public async Task<Text> GetTextById(int textId)
        {
            var text = await context.Texts.FindAsync(textId);
            return text;
        }

        public IEnumerable<Text> GetTexts()
        {
            return context.Texts.ToList();
        }

        public async void InsertTextAsync(Text text)
        {
            await context.Texts.AddAsync(text);
        }

        public void SaveAsync()
        {
            context.SaveChangesAsync();
        }

        public void UpdateText(Text text)
        {
            context.Entry(text).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}
