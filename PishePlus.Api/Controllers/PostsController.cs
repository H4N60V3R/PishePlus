using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PishePlus.Application.Posts.Commands;

namespace PishePlus.Api.Controllers
{
    public class PostsController : ApiController
    {
        [HttpPost]
        public async Task<ActionResult<int>> Create(CreatePostCommand command)
        {
            return await Mediator.Send(command);
        }
    }
}
