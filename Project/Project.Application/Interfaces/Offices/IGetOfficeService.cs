using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Application.Services.Offices.Queries.GetOffice;
using Project.Domain.Common.Dto;
using Project.Domain.Entities.Offices;

namespace Project.Application.Interfaces.Offices
{
    public interface IGetOfficeService
    {
        Task<ResultDto<ResultGetOfficeDto>> Execute(string Id);
    }
}
