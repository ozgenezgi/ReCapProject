﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;
using FluentValidation;

namespace ReCapBusiness.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.FirstName).NotNull().MaximumLength(20);
            RuleFor(u => u.LastName).NotNull().MaximumLength(20);
            RuleFor(u => u.Email).NotNull().EmailAddress();

        }
    }
}
