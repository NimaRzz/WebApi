using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Entities.Appointments
{
    public enum AppointmentStatus
    {
        Available = 1,  // نوبت آزاد
        Reserved = 2,   // نوبت رزرو شده
    }
}
