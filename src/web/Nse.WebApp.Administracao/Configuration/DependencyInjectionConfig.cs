using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Nse.WebApp.Administracao.Extensions;
using Nse.WebApp.Administracao.Services;

namespace Nse.WebApp.Administracao.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddHttpClient<IAutenticacaoService, AutenticacaoService>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IUser, AspNetUser>();
        }
    }
}
