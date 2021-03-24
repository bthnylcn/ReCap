using Business.Constants;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class BrandValidator : AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            RuleFor(b => b.Name).NotEmpty().WithMessage(Messages.CanNotBeBlank);
            RuleFor(b => b.Name).MinimumLength(2);

        }
    }

}
