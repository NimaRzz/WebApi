using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Application.Interfaces.Offices;
using Project.Domain.Common.Dto;
using Project.Domain.Entities.Offices;
using Project.Domain.Entities.Plans;
using Project.Domain.Repository.Office;

namespace Project.Application.Services.Offices.Commands.AddPlanToOffice
{
    public class AddPlanToOfficeService:IAddPlanToOfficeService
    {
        private readonly IOfficeRepository _repository;

        public AddPlanToOfficeService(IOfficeRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultDto> Execute(RequestAddPlanToOfficeDto request)
        {
            var office = await _repository.Get<Office>(request.OfficeId);
            var plan = await _repository.Get<Plan>(request.PlanId);
           
            if(!office.IsSuccess || !plan.IsSuccess)
            {
                return new ResultDto()
                {
                    IsSuccess = false,
                    Message = "دفتر یا طرحی با این شناسه وجود ندارد"
                };
            }

            OfficePlan officePlan = new()
            {
                OfficeId = request.OfficeId,
                PlanId = request.PlanId
            };

            List<OfficePlan> officePlans = new();
        
            officePlans.Add(officePlan);

            office.Data.OfficePlans = officePlans;

            plan.Data.OfficePlans = officePlans;

            await _repository.Add<OfficePlan>(officePlan);

            await _repository.SaveAsync();

            return new ResultDto()
            {
                IsSuccess = true,
                Message = "طرح با موفقیت به دفتر افزوده شد"
            };
        }
    }
}
