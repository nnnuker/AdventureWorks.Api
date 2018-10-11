using System.Data;

namespace AdventureWorks.Api.Services.Infrastructure
{
  public interface ISqlConnectionFactory
  {
    IDbConnection GetConnection();
  }
}
