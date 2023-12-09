using EmployeeCrm.Application.Repositories;
using EmployeeCrm.Persistence.Contexts;
using EmployeeCrm.Persistence.Repositories.Event;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistanceService(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(option => option.UseNpgsql(Configuration.ConnectionString));

            services.AddScoped<IEventReadRepository, EventReadRepository>();
            services.AddScoped<IEventWriteRepository, EventWriteRepository>();
        }
    }
}
