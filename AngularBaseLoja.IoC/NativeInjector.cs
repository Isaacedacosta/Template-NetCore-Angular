using AngularBaseLoja.Application.Interfaces;
using AngularBaseLoja.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace AngularBaseLoja.IoC
{
    //IOC = Inversão de controles (usado pra injeção de dependencia)
    public static class NativeInjector
    {
        public static void RegisterService(IServiceCollection builder)
        {
            builder.AddScoped<IUserService, UserService>();
        }
    }
}