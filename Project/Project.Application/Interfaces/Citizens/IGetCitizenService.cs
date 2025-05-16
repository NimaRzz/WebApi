using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Application.Services.Citizens.Queries.GetCitizen;
using Project.Domain.Common.Dto;

namespace Project.Application.Interfaces.Citizens
{
    public interface IGetCitizenService
    {
        Task<ResultDto<ResultGetCitizenDto>> Execute(long Id);
    }
}
