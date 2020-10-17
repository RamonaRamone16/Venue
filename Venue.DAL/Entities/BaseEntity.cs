using System;

namespace Venue.DAL.Entities
{
    public class BaseEntity<T> : IBaseEntity<T>
    {
        public T Id { get; set; }
        public DateTime? UpdatedUtc { get; set; }
        public DateTime CreatedUtc { get; set; }
    }
}
