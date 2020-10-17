using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Venue.DAL;
using Venue.DAL.Entities;
using Venue.Models.Models;
using Venue.Models.Models.Place;

namespace Venue.BL.Services
{
    public class PlaceService : BaseService
    {
        public PlaceService(DBContext context, IMapper mapper, UserManager<User> userManager) : base(context, mapper, userManager)
        {
        }

        public SearchModel GetAll(SearchModel model)
        {
            var places = _context.Places.Include(x => x.Photos)
                .Include(x => x.User)
                .GetByName(model.Name).OrderByDescending(x => x.CreatedUtc).ToList();

            model.Places = _mapper.Map<List<PlaceIndexModel>>(places);

            int currentPage = model.CurrentPage.HasValue ? model.CurrentPage.Value : 1;
            int pagesCount = model.Places.Count;

            PagingModel pagingModel = new PagingModel(pagesCount, currentPage);

            model.Places = model.Places.Skip((currentPage - 1) * pagingModel.PageSize).Take(pagingModel.PageSize).ToList();

            model.CurrentPage = currentPage;
            model.Paging = pagingModel;

            return model;
        }

        public async Task<PlaceIndexModel> GetById(int id)
        {
            var model = await _context.Places.Include(x => x.Photos)
                .Include(x => x.Ratings)
                .Include(x => x.User)
                .FirstOrDefaultAsync(x => x.Id == id);

            return _mapper.Map<PlaceIndexModel>(model);
        }

        public async Task Create(PlaceCreateModel model, string userId)
        {
            var place = _mapper.Map<Place>(model);
            place.UserId = userId;
            var entity = await _context.AddAsync(place);

            await CreatePhotos(model.Images, entity.Entity.Id);
        }

        public async Task AddRating(int placeId, string userId, int number)
        {
            var entity = await _context.Ratings.FirstOrDefaultAsync(x => x.PlaceId == placeId && x.UserId == userId);
            if (entity != null)
            {
                entity.Number = number;
                await _context.UpdateAsync(entity);
            }
            else
            {
                var rating = new Rating()
                {
                    PlaceId = placeId,
                    UserId = userId,
                    Number = number
                };
                await _context.AddAsync(rating);
            }
        }

        public async Task CreatePhotos(IFormFileCollection photos, int placeId)
        {
            if (photos != null)
            {
                for (int i = 0; i < photos.Count; i++)
                {
                    var photo = new Photo()
                    {
                        VenueId = placeId,
                        Picture = GetImageBytes(photos[i])
                    };
                    await _context.AddAsync(photo);
                }
            }
        }
        private byte[] GetImageBytes(IFormFile formFile)
        {
            using (var binaryReader = new BinaryReader(formFile.OpenReadStream()))
            {
                return binaryReader.ReadBytes((int)formFile.Length);
            }
        }
    }
}
