using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Application.Common.Pagination;
using Project.Application.Interfaces.Appointments;
using Project.Domain.Common.Dto;
using Project.Domain.Entities.Appointments;
using Project.Domain.Repository.Appointment;

namespace Project.Application.Services.Appointments.Queries.GetAppointments
{
    public class GetAppointmentsService : IGetAppointmentsService
    {
        private readonly IAppointmentRepository _repository;
        public GetAppointmentsService(IAppointmentRepository repository)
        {
        
        _repository = repository;
        
        }

        public async Task<ResultDto<ResultGetAppointmentsDto>> Execute(RequestGetAppointmentsDto request)
        {
            var appointments = await _repository.GetAll<Appointment>();

            if (appointments.IsSuccess == false)
            {
                return new ResultDto<ResultGetAppointmentsDto>
                {
                    IsSuccess = false,
                    Message = "داده ای یافت نشد"
                };
            }

            int totalPages = 0;

            var appointmentQuery = appointments.Data;

            var pagedResult = appointmentQuery.ToPaged(request.Page, request.PageSize, out totalPages);

            if (!string.IsNullOrEmpty(pagedResult.Message))
            {
                return new ResultDto<ResultGetAppointmentsDto>
                {
                    IsSuccess = true,
                    Message = pagedResult.Message,
                    Data = new ResultGetAppointmentsDto
                    {
                        TotalPages = totalPages,
                    }
                };
            }

            var appointmentsList = pagedResult.Data.Select((p) => new GetAppointmentsDto
            {
                Id = p.Id,
                AppointmentDateStart = p.AppointmentDateStart,
                AppointmentDateEnd = p.AppointmentDateEnd,
                CitizenId = p.CitizenId,
                PlanId = p.PlanId,
                AdminId = p.AdminId

            }).ToList();

            return new ResultDto<ResultGetAppointmentsDto>
            {
                Data = new ResultGetAppointmentsDto
                {
                    Items = appointmentsList,
                    TotalPages = totalPages
                },
                IsSuccess = true,
                Message = "لیست نوبت ها با موفقیت دریافت شد"
            };
        }
    }
}
