using PhotoStock.Models;
using PhotoStock.Models.UpdatedModels;

namespace PhotoStock.Mapping
{
    public class MappingProfiles : AutoMapper.Profile
    {
        public MappingProfiles()
        {
            CreateMap<Photo, PhotoUpdatedModel>();
            CreateMap<Photo, PhotoCreateModel>();
            CreateMap<PhotoUpdatedModel, Photo>();
            CreateMap<PhotoCreateModel, Photo>();
        }
    }
}
