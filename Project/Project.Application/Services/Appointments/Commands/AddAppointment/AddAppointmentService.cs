using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Application.Interfaces.Appointments;
using Project.Domain.Common.Dto;
using Project.Domain.Entities.Appointments;
using Project.Domain.Entities.Citizens;
using Project.Domain.Entities.Plans;
using Project.Domain.Repository.Appointment;

namespace Project.Application.Services.Appointments.Commands.AddAppointment
{
    public class AddAppointmentService:IAddAppointmentService
    {
        private readonly IAppointmentRepository _repository;

        public AddAppointmentService(IAppointmentRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultDto> Execute(RequestAddAppointmentDto request)
        {
            if (request.AppointmentDateStart == request.AppointmentDateEnd || request.AppointmentDateStart > request.AppointmentDateEnd)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "تاریخ شروع نوبت باید قبل از تاریخ پایان نوبت باشد"
                };
            }
         
            var appointmentIsExists = await _repository.IsExistsAppointment(request.AppointmentDateStart, request.AppointmentDateEnd, request.CitizenId);
            
            if (appointmentIsExists.IsSuccess)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "قسمت هایه تاریخ نوبت و انتخاب تبعه را با دقت تکمیل کنید، نباید تبعه نوبتی داشته باشد و نباید در تاریخ وارد شده نوبتی باشد"
                };
            }


            var citizenIsExists = await _repository.Get<Citizen>(request.CitizenId);
            var planIsExists = await _repository.Get<Plan>(request.PlanId);

            if (!citizenIsExists.IsSuccess || !planIsExists.IsSuccess)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "قسمت هایه انتخاب تبعه و انتخاب طرح را با دقت تکمیل کنید"
                };
            }


            Appointment appointment = new()
            {
                AppointmentDateStart = request.AppointmentDateStart,
                AppointmentDateEnd = request.AppointmentDateEnd,
                CitizenId = request.CitizenId,
                PlanId = request.PlanId,
                AdminId = request.AdminId,
                InsertTime = DateTime.Now
            };

            await _repository.Add<Appointment>(appointment);
            await _repository.SaveAsync();

            return new ResultDto
            {
                IsSuccess = true,
                Message = "نوبت با موفقیت افزوده شد"
            };


        }
    }
}
