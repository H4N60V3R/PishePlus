using FluentValidation;
using PishePlus.Application.Common.Validators;
using PishePlus.Application.Posts.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace PishePlus.Application.Posts.Validators
{
    public class CreatePostCommandValidator : AbstractValidator<CreatePostCommand>
    {
        public CreatePostCommandValidator()
        {
            RuleFor(v => v.Title).NotEmpty();
            RuleFor(v => v.Abstract).NotEmpty();
            RuleFor(v => v.Description).NotEmpty();
            RuleFor(v => v.DocumentGuid).SetValidator(new GuidPropertyValidator());
            RuleFor(v => v.Categories).SetValidator(new NotAnEmptyListPropertyValidator<Guid>());
        }
    }
}
