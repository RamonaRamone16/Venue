using AutoMapper;
using Venue.DAL.Entities;
using Venue.Models.Models.Photo;

namespace Venue.BL.Mapper.Mappings
{
    public class DomainToPhotoIndexModelProfile : Profile
    {
        public DomainToPhotoIndexModelProfile()
        {
            PhotoToPhotoIndexModelProfile();
        }

        private void PhotoToPhotoIndexModelProfile()
        {
            CreateMap<Photo, PhotoIndexModel>();
        }
    }
}
