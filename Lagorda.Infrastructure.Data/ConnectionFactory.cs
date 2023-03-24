using System.Configuration;

namespace Lagorda.Infrastructure.Data
{
    public class ConnectionFactory
    {
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ToString();
    }
}
