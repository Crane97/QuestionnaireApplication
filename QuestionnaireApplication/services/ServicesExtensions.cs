using Microsoft.EntityFrameworkCore;
using QuestionnaireApplication.repositories;

namespace QuestionnaireApplication.services
{
    public static class ServicesExtensions
    {
        public static void ConfigureMySqlContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config["mysqlconnection:connectionString"];
            services.AddDbContext<RepositoryContext>(o => o.UseMySql(connectionString,
                MySqlServerVersion.LatestSupportedServerVersion));
        }
    }
}
