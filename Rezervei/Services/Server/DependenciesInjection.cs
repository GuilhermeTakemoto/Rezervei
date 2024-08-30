using System.Runtime.CompilerServices;
using Rezervei.Repositories.Entities;
using Rezervei.Repositories.Interfaces;
using Rezervei.Services.Entities;
using Rezervei.Services.Interfaces;

namespace Rezervei.Services.Server
{
    public static class DependenciesInjection
    {
        public static void AddUserDependencies(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();

        }




    }
}
