using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using ReCapEntities.Concrete;

namespace ReCapBusiness.ValidationRules.FluentValidation
{
    public class CarImageValidator : AbstractValidator<CarImage>
    {
        public CarImageValidator()
        {
            RuleFor(c => c.CarId).NotNull();
            RuleFor(c => c.Id).NotNull();
        }
    }
}
