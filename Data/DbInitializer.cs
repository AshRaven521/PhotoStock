using PhotoStock.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoStock.Data
{
    public class DbInitializer
    {
        public static async Task Seed(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            if(!context.Authors.Any())
            {
                context.Authors.AddRange(
                    new List<Author>
                    {
                        new Author{Name = "Valera", Nickname = "Valera228", Age = 22, CreationDate = DateTime.Now},
                        new Author{Name = "Vova", Nickname = "dark_gansha", Age = 14, CreationDate = DateTime.Now},
                        new Author{Name = "Mikhail", Nickname = "lozhil_bolt", Age = 20, CreationDate = DateTime.Now}
                    });
                await context.SaveChangesAsync();
            }

            if(!context.Photos.Any())
            {
                context.Photos.AddRange(
                    new List<Photo>
                    {
                        new Photo{Name = "kazantip_2007", ContentUrl = "https://klike.net/uploads/posts/2019-06/1560838636_4.jpg", Author = new Author{
                                Name = "Nikitos", CreationDate = DateTime.Now, Age = 13, Nickname = "logger"}, 
                                Cost = 240, CreationDate = DateTime.Now, Height = 650, Width = 700, PurchaseAmount = 12 },
                        new Photo{Name = "tadzhiliston_1998", ContentUrl = "https://img.av.by/news/news_image/news_46445_2.jpg", Author = new Author{
                                Name = "Vlados", Nickname = "Verdol", Age = 21, CreationDate = DateTime.Now},
                                Cost = 190, CreationDate = DateTime.Now, Height = 700, Width = 850, PurchaseAmount = 24 }
                    });
                await context.SaveChangesAsync();
            }

            if(!context.Texts.Any())
            {
                context.Texts.AddRange(
                    new List<Text>
                    {
                        new Text{Name = "sosmyslom", Author = new Author{Name = "Evkakiy", Nickname = "rukozhop", Age = 23, CreationDate = DateTime.Now},
                                Content = "sadsaafaeaf", CreationDate = DateTime.Now, Cost = 25, Demension = 8, PurchaseAmount = 41
                        }, 
                        new Text{Name = "nesosmyslom", Author = new Author{Name = "Ilya", Nickname = "chetyrexgalzy", Age = 30, CreationDate = DateTime.Now}, 
                                Content = ".netsmysla", Cost = 210, CreationDate = DateTime.Now, Demension = 10, PurchaseAmount = 113}
                    });
                await context.SaveChangesAsync();
            }
        }
    }
}
