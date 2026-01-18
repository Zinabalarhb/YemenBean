using FluentValidation;
using YemenBean.Core.Features.Categories.Commands.Models;

namespace YemenBean.Core.Features.Categories.Commands.Validators
{
    public class CreateCategoryValidator : AbstractValidator<CreateCategoryCommandModel>
    {
        public CreateCategoryValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required");
        }
    }
}
