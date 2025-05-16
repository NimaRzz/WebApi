using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Application.Services.Plans.Commands.UpdatePlan;
using Project.Domain.Common.Dto;

namespace Project.Application.Interfaces.Plans
{
    public interface IUpdatePlanService
    {
        Task<ResultDto> Execute(RequestUpdatePlanDto request);
    }
}