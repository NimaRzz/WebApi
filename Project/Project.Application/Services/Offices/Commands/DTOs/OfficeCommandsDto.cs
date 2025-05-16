using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.Services.Offices.Commands.DTOs
{
    public class OfficeCommandsDto
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public long ProvinceId { get; set; }

        public string Address { get; set; }

        public List<OfficeWorkCalendarCommandsDto> Workdays { get; set; }

    }
}