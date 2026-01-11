using FluentValidation;
using YemenBean.Core.Features.Products.Commands.Models;

namespace YemenBean.Core.Features.Products.Commands.Validators
{
    public class UpdateProductValidator : AbstractValidator<ProductCommandModelCreate>
    {
        public UpdateProductValidator()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Price).GreaterThan(0);
        }
    }
}
