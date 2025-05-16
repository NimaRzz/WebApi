using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Application.Services.Offices.Queries.GetOffices;
using Project.Domain.Common.Dto;

namespace Project.Application.Interfaces.Offices
{
    public interface IGetOfficesService
    {
        Task<ResultDto<ResultGetOfficesDto>> Execute(RequestGetOfficesDto request);
    }
}
