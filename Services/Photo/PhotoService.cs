using AutoMapper;
using PhotoStock.DAL;
using PhotoStock.Models;
using PhotoStock.Models.UpdatedModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PhotoStock.Services
{
    public class PhotoService : IPhotoService
    {
        private readonly IMapper mapper;
        private readonly IPhotoRepository photoRepository;

        public PhotoService(IMapper mapper, IPhotoRepository repository)
        {
            this.photoRepository = repository;
            this.mapper = mapper;
        }

        public async Task DeletePhotoAsync(int photoId)
        {
            await photoRepository.DeletePhotoAsync(photoId);
        }

        public async Task<Photo> GetPhotoByIdAsync(int photoId)
        {
            return await photoRepository.GetPhotoByIdAsync(photoId);
        }

        public async Task<IEnumerable<PhotoUpdatedModel>> GetPhotosAsync()
        {
            var photos = await photoRepository.GetPhotos();
            return mapper.Map<IEnumerable<PhotoUpdatedModel>>(photos);
        }

        public async Task<PhotoCreateModel> InsertPhotoAsync(PhotoCreateModel photo)
        {
            var newPhoto = await photoRepository.InsertPhotoAsync(mapper.Map<Photo>(photo));
            return mapper.Map<PhotoCreateModel>(newPhoto);
        }

        public async Task SaveAsync()
        {
            await photoRepository.SaveAsync();
        }

        public async Task UpdatePhotoAsync(PhotoUpdatedModel photo)
        {
            await photoRepository.UpdatePhotoAsync(mapper.Map<Photo>(photo));
        }
    }
}
