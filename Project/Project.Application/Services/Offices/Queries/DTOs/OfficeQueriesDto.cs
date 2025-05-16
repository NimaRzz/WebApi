using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project.Application.Services.Offices.Queries.DTOs
{
    public class OfficeQueriesDto
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Province { get; set; }

        public List<string> Plans { get; set; }

    }
}
