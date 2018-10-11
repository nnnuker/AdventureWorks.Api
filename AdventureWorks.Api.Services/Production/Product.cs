using Dapper;

namespace AdventureWorks.Api.Services.Production
{
  public class Product
  {
    [Key]
    public int ProductId { get; set; }

    public string Name { get; set; }

    public string ProductNumber { get; set; }
  }
}
