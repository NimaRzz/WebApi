using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Application.Interfaces.Appointments;
using Project.Application.Interfaces.FacadPatterns;
using Project.Application.Services.Appointments.Commands.AddAppointment;
using Project.Application.Services.Appointments.Commands.DeleteAppointment;
using Project.Application.Services.Appointments.Queries.GetAppointments;
using Project.Domain.Repository.Appointment;

namespace Project.Application.Services.Appointments.FacadPattern
{
    public class AppointmentFacad: IAppointmentFacad
    {
        private readonly IAppointmentRepository _repository;

        public AppointmentFacad(IAppointmentRepository repository)
        {
            _repository = repository;
        }

        private IAddAppointmentService _addAppointmentService;

        public IAddAppointmentService AddAppointmentService
        {
            get
            {
                return _addAppointmentService = _addAppointmentService ?? new AddAppointmentService(_repository);
            }
        }

        private IDeleteAppointmentService _deleteAppointmentService;

        public IDeleteAppointmentService DeleteAppointmentService
        {
            get
            {
                return _deleteAppointmentService = _deleteAppointmentService ?? new DeleteAppointmentService(_repository);
            }
        }

        private IGetAppointmentsService _getAppointmentsService;

        public IGetAppointmentsService GetAppointmentsService
        {
            get
            {
                return _getAppointmentsService = _getAppointmentsService ?? new GetAppointmentsService(_repository);
            }
        }
    }
}
