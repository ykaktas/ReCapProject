using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.DailyPrice).GreaterThanOrEqualTo(1);
            RuleFor(c => c.Description.Length).GreaterThanOrEqualTo(2).WithMessage("araba adı çok kısa");
        }
    }
}
