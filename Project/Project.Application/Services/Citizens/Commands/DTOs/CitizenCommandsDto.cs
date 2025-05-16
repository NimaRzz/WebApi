using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.Services.Citizens.Commands.DTOs
{
    public class CitizenCommandsDto
    {
        public string Name { get; set; }

        public long HouseholdCode { get; set; }

        public long UniqueCode { get; set; }

        public string PassportCode { get; set; }

        public long PersonalizedCode { get; set; }
    }
}
