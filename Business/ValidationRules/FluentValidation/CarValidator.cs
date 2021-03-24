using Business.Constants;
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
            RuleFor(c => c.DailyPrice).NotEmpty().WithMessage(Messages.CanNotBeBlank);
            RuleFor(c => c.DailyPrice).GreaterThan(140);


            RuleFor(c => c.Description).NotEmpty().WithMessage(Messages.CanNotBeBlank);
            RuleFor(c => c.Description).MinimumLength(10);

            RuleFor(c => c.ModelYear).NotEmpty().WithMessage(Messages.CanNotBeBlank);
            //RuleFor(c => c.ModelName).Must(StartWithA).WithMessage("Ürün adı A harfi ile başlamalı!");
        }
    }
    //private bool StartWithA(string arg)
    //{
    //    return arg.StartsWith("A");
    //}

}



