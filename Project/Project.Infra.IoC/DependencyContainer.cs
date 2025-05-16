using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Project.Application.Interfaces.FacadPatterns;
using Project.Application.Services.Offices.FacadPattern;
using Project.Application.Services.Plans.FacadPattern;
using Project.Domain.Repository.Office;
using Project.Infra.Data.Contexts;
using Project.Infra.Data.Repositories.Office;
using Project.Domain.Repository.Plan;
using Project.Infra.Data.Repositories.Plan;
using Project.Application.Services.Citizens.FacadPattern;
using Project.Domain.Repository.Citizen;
using Project.Infra.Data.Repositories.Citizen;
using Project.Domain.Repository.Role;
using Project.Infra.Data.Repositories.Role;
using Project.Application.Services.Appointments.FacadPattern;
using Project.Infra.Data.Repositories.Appointment;
using Project.Domain.Repository.Appointment;


namespace Project.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {


            //Application Layer
            services.AddScoped<IOfficeFacad, OfficeFacad>();
            services.AddScoped<IPlanFacad, PlanFacad>();
            services.AddScoped<ICitizenFacad, CitizenFacad>();
            services.AddScoped<IAppointmentFacad, AppointmentFacad>();

            //Infra.Data Layer
            services.AddScoped<DataBaseContext>();
            services.AddScoped<IOfficeRepository, OfficeRepository>();
            services.AddScoped<IPlanRepository, PlanRepository>();
            services.AddScoped<ICitizenRepository, CitizenRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<IAppointmentRepository, AppointmentRepository>();
        }
    }
}
