using AutoMapper;
using System;
using System.Linq;
using Venue.DAL.Entities;
using Venue.Models.Models.Place;

namespace Venue.BL.Mapper.Mappings
{
    public class DomainToPlaceIndexModelProfile : Profile
    {
        public DomainToPlaceIndexModelProfile()
        {
            PlaceToPlaceIndexModelMappingConfig();
        }

        private void PlaceToPlaceIndexModelMappingConfig()
        {
            CreateMap<Place, PlaceIndexModel>()
                .ForMember(target => target.Images,
                source => source.MapFrom(x => x.Photos))
                .ForMember(target => target.Rating,
                source => source.MapFrom(x =>
                x.Ratings.Count() == 0 ? default(Decimal) : (decimal)(x.Ratings.Select(x => x.Number).Sum()/ x.Ratings.Count()))
                );
        }
    }
}
