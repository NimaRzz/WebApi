using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Application.Services.Appointments.Commands.AddAppointment;
using Project.Domain.Common.Dto;

namespace Project.Application.Interfaces.Appointments
{
    public interface IAddAppointmentService
    {
        Task<ResultDto> Execute(RequestAddAppointmentDto request);
    }
}
