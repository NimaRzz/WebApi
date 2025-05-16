using Project.Application.Interfaces.Plans;
using Project.Domain.Repository.Plan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Domain.Common.Dto;
using Project.Domain.Entities.Plans;

namespace Project.Application.Services.Plans.Queries.GetPlan
{
    public class GetPlanService:IGetPlanService
    {
        private readonly IPlanRepository _repository;

        public GetPlanService(IPlanRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultDto<ResultGetPlanDto>> Execute(string Id)
        {
            var plan = await _repository.Get<Plan>(Id);

            if (plan.Data == null)
            {
                return new ResultDto<ResultGetPlanDto>()
                {
                    IsSuccess = false,
                    Message = "طرحی با این شماره دفتر وجود ندارد"
                };
            }

            return new ResultDto<ResultGetPlanDto>()
            {
                Data = new ResultGetPlanDto()
                {
                    Id = plan.Data.Id,
                     Name = plan.Data.Name,
                    Capacity = plan.Data.Capacity,
                    EndPlan = plan.Data.EndPlan,
                    StartPlan = plan.Data.StartPlan
                },
                IsSuccess = true,
                Message = "طرح با موفقیت دریافت شد"
            };
        }
    }
}
