using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Domain.Common.Dto;

namespace Project.Application.Interfaces.Offices
{
    public interface IDeleteOfficeService
    {
        Task<ResultDto> Execute(string Id);
    }
}
