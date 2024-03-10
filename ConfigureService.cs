using FluentValidation.AspNetCore;
using TeachingWebSite.Business;
using TeachingWebSite.Contracts;
using TeachingWebSite.Models;

namespace TeachingWebSite;

public static class ConfigureService
{
    public static IServiceCollection RegisterPresentationServices(this IServiceCollection services)
    {
        services.AddScoped<ITeacherBusiness, TeacherBusiness>();
        //services.AddAutoMapper(typeof());
        services.AddFluentValidationAutoValidation();
        return services;
    }
}