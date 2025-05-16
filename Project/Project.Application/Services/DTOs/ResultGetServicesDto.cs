using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.Services.DTOs
{
    public class ResultGetServicesDto<T>
    {
        public List<T> Items { get; set; }

        public int TotalPages { get; set; }
    }
}
