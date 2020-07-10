using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace PishePlus.Application.Common.Validators
{
    public class GuidPropertyValidator : PropertyValidator
    {
        public GuidPropertyValidator()
            : base("Property {PropertyName} must be a guid type.")
        {

        }

        protected override bool IsValid(PropertyValidatorContext context)
        {
            var @string = context.PropertyValue as string;
            Guid.TryParse(@string, out Guid guid);
            return guid != Guid.Empty;
        }
    }
}
