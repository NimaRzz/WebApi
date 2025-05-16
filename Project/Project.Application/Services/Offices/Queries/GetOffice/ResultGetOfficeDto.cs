using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Application.Services.Offices.Queries.DTOs;
using Project.Application.Services.Offices.Commands.DTOs;

namespace Project.Application.Services.Offices.Queries.GetOffice
{
    public class ResultGetOfficeDto:OfficeQueriesDto
    {

        public List<OfficeWorkCalendarCommandsDto> Workdays { get; set; }
    }
}
