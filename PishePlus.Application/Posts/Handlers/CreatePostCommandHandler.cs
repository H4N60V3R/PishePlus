using MediatR;
using PishePlus.Application.Common.Interfaces;
using PishePlus.Application.Posts.Commands;
using PishePlus.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PishePlus.Application.Posts.Handlers
{
    public class CreatePostCommandHandler : IRequestHandler<CreatePostCommand, int>
    {
        private readonly IPishePlusContext _context;

        public CreatePostCommandHandler(IPishePlusContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreatePostCommand request, CancellationToken cancellationToken)
        {
            var entity = new Post
            {
                Title = request.Title,
                Abstract = request.Abstract,
                Description = request.Description,
                IsShow = request.IsShow,
                IsSuggested = request.IsSuggested,
                IsInSlider = request.IsInSlider
            };

            _context.Post.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);

            throw new NotImplementedException();
        }
    }
}
