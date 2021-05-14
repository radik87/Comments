using GuestBook.Models;
using GuestBook.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GuestBook.Services
{
    public class CommentService
    {
        private readonly CommentRepository _commentRepository;

        public CommentService(CommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public async Task<List<Comments>> Get()
        {
            return await _commentRepository.Get();
        }

        public async Task<Comments> Create(Comments comment)
        {
            return await _commentRepository.Create(comment);
        }
    }
}
