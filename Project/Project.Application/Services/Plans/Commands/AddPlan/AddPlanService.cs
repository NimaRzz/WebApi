using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Application.Interfaces.Plans;
using Project.Domain.Repository.Plan;
using Project.Application.Interfaces.Plans;
using Project.Domain.Common.Dto;
using Project.Domain.Entities.Plans;
using Project.Domain.Entities.Offices;
using Project.Application.Common.Validations.Common;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using Project.Application.Common.Validations.Plan;
using Project.Application.Common.GenerateId;

namespace Project.Application.Services.Plans.Commands.AddPlan
{
    public class AddPlanService : IAddPlanService
    {

        private readonly IPlanRepository _repository;

        public AddPlanService(IPlanRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultDto> Execute(RequestAddPlanDto request)
        {
            if (!long.TryParse(request.Id, out var tryId))
            {
                return new ResultDto()
                {
                    IsSuccess = false,
                    Message = "شناسه طرح باید عدد باشد"
                };
            }

            var planValidateResult = await PlanValidator.ValidatePlanRequest(request);

            if (!planValidateResult.IsSuccess)
            {
                return planValidateResult;
            }
            

            var existsResult = await _repository.Get<Plan>(request.Id);
            if (existsResult.IsSuccess)
            {
                return new ResultDto()
                {
                    IsSuccess = false,
                    Message = "این طرح قبلا ثبت شده"
                };
            }

            Plan plan = new()
            {
                Id = request.Id,
                Name = request.Name,
                Capacity = request.Capacity,
                StartPlan = request.StartPlan,
                EndPlan = request.EndPlan
            };

            
            

            await _repository.Add<Plan>(plan);
            await _repository.SaveAsync();



            return new ResultDto()
            {
                IsSuccess = true,
                Message = "طرح با موفقیت افزوده شد"
            };
        }
    }
}
