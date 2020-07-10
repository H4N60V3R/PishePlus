using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PishePlus.Application.Common.Validators
{
    public class NotAnEmptyListPropertyValidator<T> : PropertyValidator
    {
        public NotAnEmptyListPropertyValidator()
            : base("Property {PropertyName} must not be an empty list.")
        {

        }

        protected override bool IsValid(PropertyValidatorContext context)
        {
            var list = context.PropertyValue as IList<T>;
            return list != null && list.Any();
        }
    }
}
