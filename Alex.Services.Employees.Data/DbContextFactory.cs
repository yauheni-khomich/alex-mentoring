using Alex.Services.Employees.Data.Settings;
using Microsoft.EntityFrameworkCore;

namespace Alex.Services.Employees.Data
{
    public static class DbContextFactory
    {
        public static ApplicationDbContext CreateSqlServerDbContext(SqlServerDbContextConfig config)
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseSqlServer(config.DbConnectionString);

            return new ApplicationDbContext(builder.Options);
        }
    }
}
