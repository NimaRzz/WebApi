using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.Services.Appointments.Queries.DTOs
{
    public class AppointmentsQueriesDto
    {
        public long Id { get; set; }

        public DateTime AppointmentDateStart { get; set; }

        public DateTime AppointmentDateEnd { get; set; }

        public long CitizenId { get; set; }

        public string PlanId { get; set; }

        public string AdminId { get; set; }
    }
}
