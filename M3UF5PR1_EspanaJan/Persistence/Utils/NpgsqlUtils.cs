using Npgsql;
using Microsoft.Extensions.Configuration;
using M3UF5PR1_EspanaJan.Models;

namespace M3UF5PR1_EspanaJan.Persistence.Utils
{
    public class NpgsqlUtils
    {
        /// <summary>
        /// Opens a connection to the database. Used by the DAOs.
        /// </summary>
        /// <returns></returns>
        public static string OpenConnection()
        {
            string path = @"appsettings.json";
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile(path, optional: false, reloadOnChange: true)
                .Build();

            return config.GetConnectionString("MyPostgresConn");
        }
    }
}
