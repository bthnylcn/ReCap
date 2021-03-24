using Business.Constants;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalValidator : AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(r => r.CarId).NotEmpty().WithMessage(Messages.CanNotBeBlank);
            RuleFor(r => r.RentDate).NotEmpty().WithMessage(Messages.CanNotBeBlank);
            RuleFor(r => r.CustomerId).NotEmpty().WithMessage(Messages.CanNotBeBlank);
        }


    }
}
