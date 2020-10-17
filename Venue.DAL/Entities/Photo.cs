namespace Venue.DAL.Entities
{
    public class Photo : BaseEntity<int>
    {
        public byte[] Picture { get; set; }
        public string UserId { get; set; }
        public int VenueId { get; set; }

        public User User { get; set; }
        public Place Venue { get; set; }
    }
}
