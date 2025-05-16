using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.Services.Citizens.Queries.DTOs
{
    public class CitizenQueriesDto
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public long HouseholdCode { get; set; }

        public long UniqueCode { get; set; }

        public string PassportCode { get; set; }

        public long PersonalizedCode { get; set; }
    }
}
