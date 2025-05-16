using Project.Domain.Entities.Citizens;

namespace Project.Presentation.Areas.AdminApi.Models.DTOs.Appointments
{
    public class AppointmentDto
    {
        public DateTime AppointmentDateStart { get; set; }

        public DateTime AppointmentDateEnd { get; set; }

        public long CitizenId { get; set; }

        public string PlanId { get; set; }
    }
}
