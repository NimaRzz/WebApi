using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Application.Services.Offices.Commands.AddOffice;
using Project.Domain.Common.Dto;

namespace Project.Application.Interfaces.Offices
{
    public interface IAddOfficeService
    {
      Task<ResultDto> Execute(RequestAddOfficeDto request);
    }
}
