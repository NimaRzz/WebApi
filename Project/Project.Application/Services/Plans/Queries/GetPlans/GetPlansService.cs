using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Application.Interfaces.Plans;
using Project.Domain.Common.Dto;
using Project.Domain.Repository.Plan;
using Project.Domain.Entities.Plans;
using Project.Application.Common.Pagination;

namespace Project.Application.Services.Plans.Queries.GetPlans
{
    public class GetPlansService : IGetPlansService
    {

        private readonly IPlanRepository _repository;

        public GetPlansService(IPlanRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultDto<ResultGetPlansDto>> Execute(RequestGetPlansDto request)
        {
            var plans = await _repository.GetAll<Plan>();

            if (plans.IsSuccess == false)
            {
                return new ResultDto<ResultGetPlansDto>
                {
                    IsSuccess = false,
                    Message = "داده ای یافت نشد"
                };
            }

            int totalPages = 0;

            var planQuery = plans.Data;

            var pagedResult = planQuery.ToPaged(request.Page, request.PageSize, out totalPages);

            if (!string.IsNullOrEmpty(pagedResult.Message))
            {
                return new ResultDto<ResultGetPlansDto>()
                {
                    IsSuccess = true,
                    Message = pagedResult.Message,
                    Data = new ResultGetPlansDto()
                    {
                        TotalPages = totalPages,
                    }
                };
            }

            var plansList = pagedResult.Data.Select((p) => new GetPlansDto
            {
             Id = p.Id,
             Name = p.Name,
             Capacity = p.Capacity,
             StartPlan = p.StartPlan,
             EndPlan = p.EndPlan,
            }).ToList();

            return new ResultDto<ResultGetPlansDto>()
            {
                Data = new ResultGetPlansDto()
                {
                    Items = plansList,
                    TotalPages = totalPages
                },
                IsSuccess = true,
                Message = "لیست طرح ها با موفقیت دریافت شد"
            };
        }
    }
}
