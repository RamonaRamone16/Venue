using System;

namespace Venue.Models.Models
{
    public class PagingModel
    {
        public int CurrentPage { get; set; }
        public int PageSize { get => 6;}
        public int PagesCount { get; set; }
        public bool HaveNextPage => CurrentPage < PagesCount;
        public bool HavePreviousPage => CurrentPage > 1;

        public PagingModel(int elementsCount, int currentPage)
        {
            CurrentPage = currentPage;
            PagesCount = (int)Math.Ceiling(elementsCount / (double)PageSize);
        }
    }
}
