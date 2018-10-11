using System.Collections.Generic;

namespace AdventureWorks.Api.Services.Production
{
  public interface IProductService
  {
    void Add(Product product);

    Product Get(int id);

    IEnumerable<Product> GetProducts();

    void Remove(int id);

    void Update(Product product);
  }
}