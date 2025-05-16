using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Domain.Common.Dto;
using Project.Domain.Repository.BaseRepository;
using AppointmentModel = Project.Domain.Entities.Appointments.Appointment;


namespace Project.Domain.Repository.Appointment
{
    public interface IAppointmentRepository: IBaseRepository
    {
        Task<ResultDto<AppointmentModel>> IsExistsAppointment(DateTime Start, DateTime End, long CitizenId);
    }
}
