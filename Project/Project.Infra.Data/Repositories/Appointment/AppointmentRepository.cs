using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project.Domain.Common.Dto;
using Project.Domain.Repository.Appointment;
using Project.Infra.Data.Contexts;
using AppointmentModel = Project.Domain.Entities.Appointments.Appointment;

namespace Project.Infra.Data.Repositories.Appointment
{
    public class AppointmentRepository: BaseRepository.BaseRepository, IAppointmentRepository
    {
        private readonly DataBaseContext _context;

        public AppointmentRepository(DataBaseContext context):base(context)
        {
            _context = context;
        }

        public async Task<ResultDto<AppointmentModel>> IsExistsAppointment(DateTime Start, DateTime End, long CitizenId)
        {
            var result = await _context.Appointments.AsNoTracking().FirstOrDefaultAsync(p => p.AppointmentDateStart == Start || p.AppointmentDateEnd == End || (p.AppointmentDateStart < Start && p.AppointmentDateEnd > Start) || (p.AppointmentDateStart < End && p.AppointmentDateEnd > End) || (p.AppointmentDateStart > Start && p.AppointmentDateEnd < End) || p.CitizenId == CitizenId);
            
            if (result == null)
            {
                return new ResultDto<AppointmentModel>
                {
                    IsSuccess = false,
                };
            }
            return new ResultDto<AppointmentModel>
            {
                Data = result,
                IsSuccess = true,
            };
        }

    }
}
