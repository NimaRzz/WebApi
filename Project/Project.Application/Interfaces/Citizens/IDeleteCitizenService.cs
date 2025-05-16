using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Domain.Common.Dto;

namespace Project.Application.Interfaces.Citizens
{
    public interface IDeleteCitizenService
    {
        Task<ResultDto> Execute(long Id);
    }
}
