using FluentValidation;
using YemenBean.Core.Features.Categories.Commands.Models;

namespace YemenBean.Core.Features.Categories.Commands.Validators
{
    public class UpdateCategoryValidator : AbstractValidator<UpdateCategoryCommandModel>
    {
        public UpdateCategoryValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0);
            RuleFor(x => x.Name).NotEmpty();
        }
    }
}
