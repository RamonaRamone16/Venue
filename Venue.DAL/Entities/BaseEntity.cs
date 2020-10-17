using System;
using System.Collections.Generic;
using System.Text;

namespace Venue.DAL.Entities
{
    public class BaseEntity<T> : IBaseEntity<T>
    {
        public T Id { get; set; }
    }
}
