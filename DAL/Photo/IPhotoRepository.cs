using PhotoStock.Models;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace PhotoStock.DAL
{
    public interface IPhotoRepository
    {
        Task<IEnumerable<Photo>> GetPhotos();
        Task<Photo> GetPhotoByIdAsync(int photoId);
        Task<Photo> InsertPhotoAsync(Photo photo);
        Task DeletePhotoAsync(int photoId);
        Task UpdatePhotoAsync(Photo photo);
        Task SaveAsync();
    }
}
