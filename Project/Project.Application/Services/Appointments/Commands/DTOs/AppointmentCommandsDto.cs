using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Domain.Entities.Citizens;

namespace Project.Application.Services.Appointments.Commands.DTOs
{
    public class AppointmentCommandsDto
    {
        public DateTime AppointmentDateStart { get; set; }

        public DateTime AppointmentDateEnd { get; set; }

        public string AdminId { get; set; }

        public long CitizenId { get; set; }

        public string PlanId { get; set; }
    }
}
