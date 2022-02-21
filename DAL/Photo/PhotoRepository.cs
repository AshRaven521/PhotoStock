using PhotoStock.Controllers;
using PhotoStock.Data;
using PhotoStock.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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


        public async void DeletePhotoAsync(int photoId)
        {
            var photo = await context.Photos.FindAsync(photoId);
            context.Photos.Remove(photo);
        }

        public async Task<Photo> GetPhotoById(int photoId)
        {
            var photo = await context.Photos.FindAsync(photoId);
            return photo;
        }

        public IEnumerable<Photo> GetPhotos()
        {
            return context.Photos.ToList();
        }

        public async void InsertPhotoAsync(Photo photo)
        {
            await context.Photos.AddAsync(photo);
        }

        public void SaveAsync()
        {
            context.SaveChangesAsync();
        }

        public void UpdatePhoto(Photo photo)
        {
            context.Entry(photo).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}
