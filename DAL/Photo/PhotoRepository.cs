using Microsoft.EntityFrameworkCore;
using PhotoStock.Data;
using PhotoStock.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PhotoStock.DAL
{
    public class PhotoRepository : IPhotoRepository
    {
        private ApplicationDbContext context;

        public PhotoRepository(ApplicationDbContext context)
        {
            this.context = context;
        }


        public async Task DeletePhotoAsync(int photoId)
        {
            var photo = await context.Photos.FindAsync(photoId);
            context.Photos.Remove(photo);
            await context.SaveChangesAsync();
        }

        public async Task<Photo> GetPhotoByIdAsync(int photoId)
        {
            var photo = await context.Photos.FindAsync(photoId);
            return photo;
        }

        public async Task<IEnumerable<Photo>> GetPhotos()
        {
            return await context.Photos.ToListAsync();
        }

        public async Task<Photo> InsertPhotoAsync(Photo photo)
        {
            var newPhoto = await context.Photos.AddAsync(photo);
            await context.SaveChangesAsync();

            return newPhoto.Entity;
        }

        public async Task SaveAsync()
        {
            await context.SaveChangesAsync();
        }

        public async Task UpdatePhotoAsync(Photo newPhoto)
        {
            var photo = await context.Photos.FindAsync(newPhoto.Id);
            photo.Name = newPhoto.Name;
            photo.Height = newPhoto.Height;
            photo.Width = newPhoto.Width;
            photo.ContentUrl = newPhoto.ContentUrl;
            photo.Cost = newPhoto.Cost;
            photo.PurchaseAmount = newPhoto.PurchaseAmount;

            await context.SaveChangesAsync();



        }
    }
}
