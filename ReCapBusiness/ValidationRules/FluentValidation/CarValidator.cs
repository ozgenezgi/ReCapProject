using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using ReCapEntities.Concrete;

namespace ReCapBusiness.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.DailyPrice).GreaterThan(0);
            RuleFor(c => c.Description).MinimumLength(3);
            
        }
    }
}
