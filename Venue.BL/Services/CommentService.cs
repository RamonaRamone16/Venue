using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Venue.DAL;
using Venue.DAL.Entities;
using Venue.Models.Models.Comment;

namespace Venue.BL.Services
{
    public class CommentService : BaseService
    {
        public CommentService(DBContext context, IMapper mapper, UserManager<User> userManager) : base(context, mapper, userManager)
        {
        }

        public async Task<List<CommentIndexModel>> GetAll(int placeId)
        {
            var models = await _context.Comments.Where(x => x.VenueId == placeId)
                .Include(x => x.User)
                .OrderByDescending(x => x.CreatedUtc)
                .ToListAsync();

            return _mapper.Map<List<CommentIndexModel>>(models);
        }

        public async Task Create(CommentCreateModel model, string userId)
        {
            var entity = _mapper.Map<Comment>(model);
            entity.UserId = userId;

            await _context.AddAsync(entity);
        }

        public async Task Delete(int id)
        {
            var model = await _context.Comments.FirstOrDefaultAsync(x => x.Id == id);
            await _context.RemoveAsync(model);
        }
    }
}
