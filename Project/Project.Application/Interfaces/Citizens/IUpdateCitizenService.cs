using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Application.Services.Citizens.Commands.UpdateCitizen;
using Project.Domain.Common.Dto;

namespace Project.Application.Interfaces.Citizens
{
    public interface IUpdateCitizenService
    {
        Task<ResultDto> Execute(RequestUpdateCitizenDto request);
    }
}
