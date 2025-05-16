using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Project.Application.Interfaces.FacadPatterns;
using Project.Application.Services.Appointments.Commands.AddAppointment;
using Project.Application.Services.Appointments.FacadPattern;
using Project.Application.Services.Citizens.Queries.GetCitizens;
using Project.Application.Services.Plans.Queries.GetPlans;
using Project.Infra.Data;
using Project.Presentation.Areas.Admin.Models.DTOs.Common.Pagination;


namespace Project.Presentation.Areas.Admin.Controllers
{
    //[Authorize("AdminOrOperator")]
    [Area("Admin")]
    public class AppointmentsController : Controller
    {
        private readonly IAppointmentFacad _appointmentFacad;

        private readonly ICitizenFacad _citizenFacad;

        private readonly IPlanFacad _planFacad;

        private readonly UserManager<User> _userManager;


        public AppointmentsController(IAppointmentFacad appointmentFacad, ICitizenFacad citizenFacad, IPlanFacad planFacad, UserManager<User> userManager)
        {
            _appointmentFacad = appointmentFacad;

            _citizenFacad = citizenFacad;

            _planFacad = planFacad;

            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
