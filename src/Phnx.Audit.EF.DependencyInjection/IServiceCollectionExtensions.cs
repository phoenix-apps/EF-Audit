﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Phnx.Audit.EF
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddPhoenixAuditing<TContext>(this IServiceCollection services)
            where TContext : DbContext
        {
            services.AddTransient<IAuditService<TContext>, AuditService<TContext>>();
            services.AddTransient<IChangeDetectionService, ChangeDetectionService>();
            services.AddTransient<IChangeSerializerService, JsonSerializerService>();

            return services;
        }
    }
}
