using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Application.Services.Offices.Commands.AddPlanToOffice;
using Project.Domain.Common.Dto;

namespace Project.Application.Interfaces.Offices
{
    public interface IAddPlanToOfficeService
    {
        Task<ResultDto> Execute(RequestAddPlanToOfficeDto request);
    }
}
