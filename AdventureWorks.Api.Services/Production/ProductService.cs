using AdventureWorks.Api.Services.Infrastructure;
using Dapper;
using System.Collections.Generic;

namespace AdventureWorks.Api.Services.Production
{
  public class ProductService : IProductService
  {
    private readonly ISqlConnectionFactory _sqlConnectionFactory;

    public ProductService(ISqlConnectionFactory sqlConnectionFactory)
    {
      _sqlConnectionFactory = sqlConnectionFactory;
    }

    public IEnumerable<Product> GetProducts()
    {
      using (var conn = _sqlConnectionFactory.GetConnection())
      {
        return conn.GetList<Product>();
      }
    }

    public Product Get(int id)
    {
      using (var conn = _sqlConnectionFactory.GetConnection())
      {
        return conn.Get<Product>(id);
      }
    }

    public void Add(Product product)
    {
      using (var conn = _sqlConnectionFactory.GetConnection())
      {
        conn.Insert<Product>(product);
      }
    }

    public void Update(Product product)
    {
      using (var conn = _sqlConnectionFactory.GetConnection())
      {
        conn.Update<Product>(product);
      }
    }

    public void Remove(int id)
    {
      using (var conn = _sqlConnectionFactory.GetConnection())
      {
        conn.Delete<Product>(id);
      }
    }
  }
}
