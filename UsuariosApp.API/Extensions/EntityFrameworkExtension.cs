using Microsoft.EntityFrameworkCore;
using UsuariosApp.API.Contexts;

namespace UsuariosApp.API.Extensions
{
    public static class EntityFrameworkExtension
    {
        public static IServiceCollection AddEntityFrameworkConfig(this IServiceCollection services, IConfiguration configuration)
        {
            //capturando a string de conexão do /appsetting
            var connectionString = configuration.GetConnectionString("UsuariosApp");

            //injeção de dependência do conteexto do EntityFramework
            services.AddDbContext<DataContext>(options => options.UseSqlServer(connectionString));

            return services;
        }
    }
}
