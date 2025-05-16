using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Application.Services.Citizens.Queries.GetCitizens;
using Project.Domain.Common.Dto;
using Project.Domain.Entities.Citizens;

namespace Project.Application.Interfaces.Citizens
{
    public interface IGetCitizensService
    {
        Task<ResultDto<ResultGetCitizensDto>> Execute(RequestGetCitizensDto request);
    }
}
