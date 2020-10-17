using AutoMapper;
using Venue.DAL.Entities;
using Venue.Models.Models.Comment;

namespace Venue.BL.Mapper.Mappings
{
    public class DomainToCommentIndexModelProfile : Profile
    {
        public DomainToCommentIndexModelProfile()
        {
            CommentToCommentIndexModelMappingConfig();
        }

        private void CommentToCommentIndexModelMappingConfig()
        {
            CreateMap<Comment, CommentIndexModel>()
                .ForMember(target => target.User,
                source => source.MapFrom(x => x.User.Email));
        }
    }
}
