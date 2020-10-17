using System;

namespace Venue.Models.Models.Comment
{
    public class CommentIndexModel : CommentCreateModel
    {
        public int Id { get; set; }
        public string User { get; set; }
        public DateTime CreatedUtc { get; set; }
    }
}
