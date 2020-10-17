using AutoMapper;
using Venue.DAL.Entities;
using Venue.Models.Models.Place;

namespace Venue.BL.Mapper.Mappings
{
    public class DomainToPlaceDetailsModelProfile : Profile
    {
        public DomainToPlaceDetailsModelProfile()
        {
            PlaceToPlaceDetailsModelMappingConfig();
        }

        private void PlaceToPlaceDetailsModelMappingConfig()
        {
            CreateMap<Place, PlaceIndexModel>()
                .ForMember(target => target.Images,
                source => source.MapFrom(x => x.Photos));
        }
    }
}
