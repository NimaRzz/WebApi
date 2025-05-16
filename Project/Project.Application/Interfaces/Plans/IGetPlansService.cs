using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Application.Services.Plans.Queries.DTOs;
using Project.Domain.Common.Dto;
using Project.Application.Services.Plans.Queries.GetPlans;

namespace Project.Application.Interfaces.Plans
{
    public interface IGetPlansService
    {
        Task<ResultDto<ResultGetPlansDto>> Execute(RequestGetPlansDto request);
    }
}
