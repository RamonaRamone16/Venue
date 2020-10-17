using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Venue.DAL;
using Venue.DAL.Entities;

namespace Venue.BL.Services
{
    public class BaseService
    {
        protected readonly DBContext _context;
        protected readonly IMapper _mapper;
        protected readonly UserManager<User> _userManager;

        public BaseService(DBContext context, IMapper mapper, UserManager<User> userManager)
        {
            _context = context;
            _mapper = mapper;
            _userManager = userManager;
        }
    }
}
