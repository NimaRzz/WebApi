using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Application.Interfaces.Offices;
using Project.Domain.Common.Dto;
using Project.Domain.Repository.Office;
using Project.Domain.Entities.Offices;
using Project.Domain.Entities.Plans;

namespace Project.Application.Services.Offices.Commands.DeleteOfficePlan
{
    public class DeleteOfficePlanService  :IDeleteOfficePlanService
    {
        private readonly IOfficeRepository _repository;

        public DeleteOfficePlanService(IOfficeRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultDto> Execute(RequestDeleteOfficePlanDto request)
        {
            var office = await _repository.Get<Office>(request.OfficeId);
            var plan = await _repository.Get<Plan>(request.PlanId);

            if (!office.IsSuccess || !plan.IsSuccess)
            {
                return new ResultDto()
                {
                    IsSuccess = false,
                    Message = "دفتر یا طرحی با این شناسه وجود ندارد"
                };
            }
        
            var officePlan = await _repository.GetOfficePlan(request.OfficeId, request.PlanId);


            await _repository.Delete<OfficePlan>(officePlan.Data);

            await _repository.SaveAsync();

            return new ResultDto()
            {
                IsSuccess = true,
                Message = "طرح با موفقیت از دفتر حذف شد"
            };
        }
    }
}
