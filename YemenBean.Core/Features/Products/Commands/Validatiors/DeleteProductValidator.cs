using FluentValidation;
using YemenBean.Core.Features.Products.Commands.Models;

namespace YemenBean.Core.Features.Products.Commands.Validators
{
    public class DeleteProductValidator : AbstractValidator<ProductCommandModelCreate>
    {
        public DeleteProductValidator()
        {
            RuleFor(x => x.Id).NotNull();
        }
    }
}
