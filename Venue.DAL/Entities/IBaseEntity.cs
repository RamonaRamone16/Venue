using EntityFrameworkCore.CommonTools;

namespace Venue.DAL.Entities
{
    public interface IBaseEntity<T> : IBaseEntity
    {
        public T Id { get; set; }
    }

    public interface IBaseEntity : IModificationTrackable, ICreationTrackable
    {
    }
}
