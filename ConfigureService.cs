using TeachingWebSite.Contracts;
using TeachingWebSite.Models;

namespace TeachingWebSite;

public static class ConfigureService
{
    public static IServiceCollection RegisterPresentationServices(this IServiceCollection services)
    {
        //services.AddScoped<ITeacherBusiness, Teacher>()

        return services;
    }
}