using Project.Application.Services.Plans.Queries.GetPlan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Domain.Common.Dto;

namespace Project.Application.Interfaces.Plans
{
    public interface IGetPlanService
    {
        Task<ResultDto<ResultGetPlanDto>> Execute(string Id);
    }
}
