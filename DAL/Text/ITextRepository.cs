using PhotoStock.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PhotoStock.DAL
{
    interface ITextRepository
    {
        IEnumerable<Text> GetTexts();
        Task<Text> GetTextById(int textId);
        void DeleteTextAsync(int textId);
        void InsertTextAsync(Text text);
        void SaveAsync();
        void UpdateText(Text text);
    }
}
