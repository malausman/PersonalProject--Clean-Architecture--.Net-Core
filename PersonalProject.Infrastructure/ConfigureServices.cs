﻿using PersonalProject.Domain.IRepositories;
using PersonalProject.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Cqrs.Hosts;

namespace PersonalProject.Infrastructure
{
    public static class ConfigureServices
    {
        public static IServiceCollection ConfigureBugsData(this IServiceCollection services)
        {

           
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IBugsRepository, BugsRepository>();
            
            return services;
        }
    }
}
