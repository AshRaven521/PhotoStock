using PhotoStock.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace PhotoStock.DAL
{
    interface IPhotoRepository
    {
        IEnumerable<Photo> GetPhotos();
        Task<Photo> GetPhotoById(int photoId);
        void InsertPhotoAsync(Photo photo);
        void DeletePhotoAsync(int photoId);
        void UpdatePhoto(Photo photo);
        void SaveAsync();
    }
}
