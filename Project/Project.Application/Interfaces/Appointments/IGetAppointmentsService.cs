using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Application.Services.Appointments.Queries.GetAppointments;
using Project.Domain.Common.Dto;

namespace Project.Application.Interfaces.Appointments
{
    public interface IGetAppointmentsService
    {
        Task<ResultDto<ResultGetAppointmentsDto>> Execute(RequestGetAppointmentsDto request);
    }
}
