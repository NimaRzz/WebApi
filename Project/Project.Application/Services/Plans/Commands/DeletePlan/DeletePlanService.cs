using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Application.Interfaces.Plans;
using Project.Domain.Repository.Plan;
using Project.Domain.Common.Dto;
using Project.Domain.Entities.Plans;

namespace Project.Application.Services.Plans.Commands.DeletePlan
{
    public class DeletePlanService:IDeletePlanService
    {

        private readonly IPlanRepository _repository;

        public DeletePlanService(IPlanRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultDto> Execute(string Id)
        {
            var entity = await _repository.Get<Plan>(Id);

            if (!entity.IsSuccess)
            {
                return new ResultDto()
                {
                    IsSuccess = false,
                    Message = "طرحی با این شناسه یافت نشد"
                };
            }

            await _repository.Delete<Plan>(entity.Data);
            await _repository.SaveAsync();

            return new ResultDto()
            {
                IsSuccess = true,
                Message = "طرح با موفقیت حذف شد"
            };
        }
    }
}
