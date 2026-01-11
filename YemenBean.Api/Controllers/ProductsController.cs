using Microsoft.AspNetCore.Mvc;
using MediatR;
using YemenBean.Core.Features.Products.Queries;
using YemenBean.Core.Features.Products.Queries.Result;
using YemenBean.Core.Features.Products.Commands.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace YemenBean.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            List<ProductResult> products = await _mediator.Send(new GetAllProductsQuery());
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            ProductResult product = await _mediator.Send(new GetProductByIdQuery(id));
            if (product == null) return NotFound();
            return Ok(product);
        }

        [HttpPost]
            public async Task<IActionResult> Create([FromBody] ProductCommandModelCreate model)
            {
                if (!ModelState.IsValid) return BadRequest(ModelState);
                int id = await _mediator.Send(model); // CreateProductHandler
                return CreatedAtAction(nameof(GetById), new { id }, model);
            }
            
        [HttpPost("upload")]
        public async Task<IActionResult> UploadImage(IFormFile file)
        {
        if (file == null || file.Length == 0)
            return BadRequest("No file selected");

        // المجلد الذي سيتم حفظ الصورة فيه
        var folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "products");

        if (!Directory.Exists(folderPath))
            Directory.CreateDirectory(folderPath);

        // اسم الصورة (يمكنك إضافة وقت الآن لتجنب التكرار)
        var fileName = $"{Guid.NewGuid()}_{file.FileName}";
        var filePath = Path.Combine(folderPath, fileName);

        using (var stream = new FileStream(filePath, FileMode.Create))
        {
            await file.CopyToAsync(stream);
        }

        // إرجاع رابط الصورة للـ frontend
        var url = $"/images/products/{fileName}";
        return Ok(new { Url = url });
    }


        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] ProductCommandModelUpdate model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            model.Id = id;
            bool result = await _mediator.Send(model); // UpdateProductHandler
            if (!result) return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var model = new ProductCommandModelDelete { Id = id };
            bool result = await _mediator.Send(model); // DeleteProductHandler
            if (!result) return NotFound();
            return NoContent();
        }
    }
}
