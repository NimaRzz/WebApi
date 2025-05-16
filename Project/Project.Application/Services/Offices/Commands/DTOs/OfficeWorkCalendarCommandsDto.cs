using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Domain.Entities.Offices;

namespace Project.Application.Services.Offices.Commands.DTOs
{
    public class OfficeWorkCalendarCommandsDto
    {
        public string WorkStart { get; set; }

        public string WorkEnd { get; set; }

        public DaysOfTheWeek Workday { get; set; }
    }
}
