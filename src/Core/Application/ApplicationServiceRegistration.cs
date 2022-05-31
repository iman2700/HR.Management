using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Application
{
    public static class ApplicationServiceRegistration
    {
        public static void ConfigurationApplicationServiced(this IServiceCollection services) 
        {
                services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }
    }
}
