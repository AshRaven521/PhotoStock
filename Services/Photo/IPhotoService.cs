using PhotoStock.Models;
using PhotoStock.Models.UpdatedModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PhotoStock.Services
{
    public interface IPhotoService
    {
        Task<IEnumerable<PhotoUpdatedModel>> GetPhotosAsync();
        Task<Photo> GetPhotoByIdAsync(int photoId);
        Task<PhotoCreateModel> InsertPhotoAsync(PhotoCreateModel photo);
        Task DeletePhotoAsync(int photoId);
        Task UpdatePhotoAsync(PhotoUpdatedModel photo);
        Task SaveAsync();
    }
}

