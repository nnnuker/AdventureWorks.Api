using AdventureWorks.Api.Services.Production;
using System.Collections.Generic;
using System.Web.Http;

namespace AdventureWorks.Api.Controllers
{
  public class ProductController : ApiController
  {
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
      _productService = productService;
    }

    // GET api/products
    public IEnumerable<Product> Get()
    {
      return _productService.GetProducts();
    }

    // GET api/products/5
    public Product Get(int id)
    {
      return _productService.Get(id);
    }

    // POST api/products
    public void Post([FromBody]Product value)
    {
      _productService.Add(value);
    }

    // PUT api/products/5
    public void Put(int id, [FromBody]Product value)
    {
      _productService.Update(value);
    }

    // DELETE api/products/5
    public void Delete(int id)
    {
      _productService.Remove(id);
    }
  }
}
