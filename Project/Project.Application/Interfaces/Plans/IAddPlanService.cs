using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Domain.Common.Dto;
using Project.Application.Services.Plans.Commands.AddPlan;

namespace Project.Application.Interfaces.Plans
{
    public interface IAddPlanService
    {
        Task<ResultDto> Execute(RequestAddPlanDto request);
    }
}
