using System;
using System.Collections.Generic;
using Venue.Models.Models.Photo;

namespace Venue.Models.Models.Place
{
    public class PlaceIndexModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Rating { get; set; }
        public string User { get; set; }
        public DateTime CreatedUtc { get; set; }
        public List<PhotoIndexModel> Images { get; set; }
    }
}
