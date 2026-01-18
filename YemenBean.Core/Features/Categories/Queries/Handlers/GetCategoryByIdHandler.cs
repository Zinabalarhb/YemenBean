using MediatR;
using YemenBean.Core.Features.Categories.Queries.Models;
using YemenBean.Core.Features.Categories.Queries.Results;
using YemenBean.Infrastructure.Context;

public class GetCategoryByIdHandler : IRequestHandler<GetCategoryByIdQuery, CategoryResult>
{
    private readonly ApplicationDbContext _context;

    public GetCategoryByIdHandler(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<CategoryResult> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
    {
        var category = await _context.Categories.FindAsync(request.Id);

        if (category == null)
            throw new Exception("Category not found");

        return new CategoryResult
        {
            Id = category.Id,
            Name = category.Name
        };
    }
}
