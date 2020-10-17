using AutoMapper;
using Venue.BL.Mapper.Mappings;

namespace Venue.BL.Mapper
{
    public class MappingConfiguration
    {
        public MapperConfiguration RefisterMappings()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new DomainToPlaceIndexModelProfile());
                cfg.AddProfile(new PlaceCraeteModelToDomainProfile());
                cfg.AddProfile(new DomainToPhotoIndexModelProfile());
                cfg.AddProfile(new DomainToPlaceDetailsModelProfile());
                cfg.AddProfile(new CommentCraeteModelToDomainProfile());
                cfg.AddProfile(new DomainToCommentIndexModelProfile());
            });
        }
    }
}
