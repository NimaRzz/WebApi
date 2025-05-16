using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Domain.Entities.Appointments;
using Project.Domain.Entities.Citizens;
using Project.Domain.Entities.Plans;

namespace Project.Domain.Entities.Appointments
{
    public class Appointment:BaseEntity.BaseEntity
    {

        // تاریخ و ساعت نوبت
        public DateTime AppointmentDateStart { get; set; }
      
        public DateTime AppointmentDateEnd { get; set; }

        // اطلاعات ادمینی که نوبت را رزرو کرده
        public string AdminId { get; set; }

        // اطلاعات کاربری که نوبت را رزرو کرده
        public long CitizenId { get; set; }

        public Citizen Citizen { get; set; }

        // اطلاعات طرحی که برای آن نوبت رزرو شده
        public string PlanId { get; set; }

        public Plan Plan { get; set; }

    }
}
