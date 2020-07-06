using FSA.IncidentsManagement.Models;
using FSA.IncidentsManagement.Root.Contracts;
using FSA.IncidentsManagement.Root.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    [Authorize]
    public class ProductsController :ControllerBase
    {
        private ILogger<LookupsController> log;
        private readonly ISIMSManager fsaData;

        public ProductsController(ILogger<LookupsController> log, ISIMSManager fsaData)
        {
            this.log = log;
            this.fsaData = fsaData;
        }


        [HttpPost("")]
        [SwaggerOperation(Summary = "Create new Product.")]
        [ProducesResponseType(typeof(Product), 200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> AddProduct([FromBody] NewProductModel newProduct)
        {
            var item = newProduct.ToClient();
            var product = await this.fsaData.Products.Add(newProduct.IncidentId, item);
            return new OkObjectResult(product);
        }

        [HttpPut("")]
        [SwaggerOperation(Summary = "Update Product.")]
        [ProducesResponseType(typeof(Product), 200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> UpdateProduct([FromBody] NewProductModel product)
        {
            var updatedProduct = await this.fsaData.Products.Update(product.ToClient());
            return new OkObjectResult(updatedProduct);
        }

    }
}
