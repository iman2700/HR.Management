using Application.Contracts.Infrastructure;
using Application.Model;
using Infrastructure.Mail;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
 

namespace Infrastructure
{
  public  static class InfrastructureServiceRegistration
    {
        public static IServiceCollection ConfigurationInfrastructureService(this IServiceCollection services, IConfiguration configuration) 
        {
            services.Configure<EmailSetting>(configuration.GetSection("EmailSettings"));
            services.AddTransient<IEmailSender, EmailSender>();
            return services;
        }
    }
}
