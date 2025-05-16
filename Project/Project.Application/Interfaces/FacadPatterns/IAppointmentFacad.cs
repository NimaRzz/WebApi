using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Application.Interfaces.Appointments;

namespace Project.Application.Interfaces.FacadPatterns
{
    public interface IAppointmentFacad
    {
        IAddAppointmentService AddAppointmentService { get; }
       
        IDeleteAppointmentService DeleteAppointmentService { get; }
      
        IGetAppointmentsService GetAppointmentsService { get; }
    }
}
