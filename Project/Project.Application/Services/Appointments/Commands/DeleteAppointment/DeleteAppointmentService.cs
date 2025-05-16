using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Application.Interfaces.Appointments;
using Project.Domain.Common.Dto;
using Project.Domain.Entities.Appointments;
using Project.Domain.Repository.Appointment;

namespace Project.Application.Services.Appointments.Commands.DeleteAppointment
{
    public class DeleteAppointmentService:IDeleteAppointmentService
    {
        private readonly IAppointmentRepository _repository;

        public DeleteAppointmentService(IAppointmentRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultDto> Execute(long Id)
        {
            var result = await _repository.Get<Appointment>(Id);

            if (!result.IsSuccess)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "هیچ نوبتی با این ایدی وجود ندارد"
                };
            }

            await _repository.Delete<Appointment>(result.Data);
            await _repository.SaveAsync();

            return new ResultDto
            {
                IsSuccess = true,
                Message = "نوبت با موفقیت حذف شد"
            };
        }
    }
}
