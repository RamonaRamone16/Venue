using AutoMapper;
using Venue.DAL.Entities;
using Venue.Models.Models.Comment;

namespace Venue.BL.Mapper.Mappings
{
    public class CommentCraeteModelToDomainProfile : Profile
    {
        public CommentCraeteModelToDomainProfile()
        {
            CommentCraeteModelToCommentMappingConfig();
        }

        private void CommentCraeteModelToCommentMappingConfig()
        {
            CreateMap<CommentCreateModel, Comment>()
                .ForMember(target => target.VenueId,
                source => source.MapFrom(x => x.PlaceId));
        }
    }
}
