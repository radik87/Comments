using GuestBook.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GuestBook.Repository
{
    public class CommentRepository
    {
        private readonly CommentContext _commentContext;

        public CommentRepository(CommentContext commentContext)
        {
            _commentContext = commentContext;
        }

        public async Task<List<Comments>> Get()
        {
            return await _commentContext.Comments.ToListAsync();
        }

        public async Task<Comments> Create(Comments comment)
        {
                _commentContext.Comments.Add(comment);
                await _commentContext.SaveChangesAsync();

            return comment;
        }
    }
}
