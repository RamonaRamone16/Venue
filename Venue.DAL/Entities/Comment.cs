namespace Venue.DAL.Entities
{
    public class Comment : BaseEntity<int>
    {
        public string Text { get; set; }
        public string UserId { get; set; }
        public int VenueId { get; set; }

        public User User { get; set; }
        public Place Venue { get; set; }
    }
}
