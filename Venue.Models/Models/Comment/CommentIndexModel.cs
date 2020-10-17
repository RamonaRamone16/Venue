using System;

namespace Venue.Models.Models.Comment
{
    public class CommentIndexModel : CommentCreateModel
    {
        public string User { get; set; }
        public DateTime CreatedUtc { get; set; }
    }
}
