using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Application.Services.Citizens.Commands.AddCitizen;
using Project.Domain.Common.Dto;

namespace Project.Application.Interfaces.Citizens
{
    public interface IAddCitizenService
    {
        Task<ResultDto> Execute(RequestAddCitizenDto request);
    }
}
