using FluentValidation;
using YemenBean.Core.Features.Products.Commands.Models;

namespace YemenBean.Core.Features.Products.Commands.Validators
{
    public class CreateProductValidator : AbstractValidator<ProductCommandModelCreate>
    {
        public CreateProductValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Price).GreaterThan(0);
        }
    }
}
