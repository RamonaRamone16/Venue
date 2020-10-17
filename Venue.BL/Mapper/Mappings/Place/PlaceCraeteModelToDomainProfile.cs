using AutoMapper;
using Venue.DAL.Entities;
using Venue.Models.Models;

namespace Venue.BL.Mapper.Mappings
{
    public class PlaceCraeteModelToDomainProfile : Profile
    {
        public PlaceCraeteModelToDomainProfile()
        {
            PlaceCraeteModelToPlaceMappingConfig();
        }

        private void PlaceCraeteModelToPlaceMappingConfig()
        {
            CreateMap<PlaceCreateModel, Place>();
        }
    }
}
