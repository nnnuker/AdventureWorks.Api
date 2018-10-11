using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using AdventureWorks.Api.Services.Infrastructure;

namespace AdventureWorks.Api.Infrastructure
{
  public class SqlConnectionFactory : ISqlConnectionFactory
  {
    public IDbConnection GetConnection()
    {
      var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
      return new SqlConnection(connectionString);
    }
  }
}