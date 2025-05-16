using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Common.Dto
{
    public class ResultDto<T>:ResultDto
    {
        public T Data { get; set; }

    }

    public class ResultDto
    {
        public bool IsSuccess { get; set; }

        public string Message { get; set; }
    }
}
