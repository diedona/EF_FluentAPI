using Microsoft.EntityFrameworkCore;
using Persistence.Context;

namespace WebApi.IoC.Persistence;

public static class DatabaseExtensions
{
    public static void AddDatabase(this WebApplicationBuilder builder)
    {
        builder.Services.AddDbContext<MyDbContext>(opt =>
         {
             opt.UseNpgsql(
                 connectionString: builder.Configuration.GetConnectionString("default")
             );
         });
    }
}
