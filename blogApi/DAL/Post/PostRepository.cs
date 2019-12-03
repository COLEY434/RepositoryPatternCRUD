using blogApi.DTOS.ReadDTO;
using blogApi.Entities;
using blogApi.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blogApi.DAL.Post
{
    public class PostRepository : BaseRepository<posts>, IPostRepository
    {
        private readonly RepositoryContext context;
        public PostRepository(RepositoryContext _context) : base(_context)
        {
            context = _context;
        }

        public async Task<List<GetPostReadDTO>> GetPostsAsync()
        {
            var result = await context.GetPostReadDTOs.ToListAsync();
                 
            return result;
        }
    }
}
