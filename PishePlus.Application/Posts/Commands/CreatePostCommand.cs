using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace PishePlus.Application.Posts.Commands
{
    public class CreatePostCommand : IRequest<int>
    {
        public CreatePostCommand()
        {
            Categories = new List<Guid>();
            Tags = new List<string>();
        }

        public string DocumentGuid { get; set; }
        public string Title { get; set; }
        public string Abstract { get; set; }
        public string Description { get; set; }
        public bool IsShow { get; set; }
        public bool IsSuggested { get; set; }
        public bool IsInSlider { get; set; }

        public IList<Guid> Categories { get; set; }
        public IList<string> Tags { get; set; }
    }
}
