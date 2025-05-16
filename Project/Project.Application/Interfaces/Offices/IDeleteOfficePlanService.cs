using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Application.Services.Offices.Commands.DeleteOfficePlan;
using Project.Domain.Common.Dto;

namespace Project.Application.Interfaces.Offices
{
    public interface IDeleteOfficePlanService
    {
        Task<ResultDto> Execute(RequestDeleteOfficePlanDto request);
    }
}
