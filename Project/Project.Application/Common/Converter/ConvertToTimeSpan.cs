using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Domain.Common.Dto;

namespace Project.Application.Common.Converter
{
    public class ConvertToTimeSpan
    {
        public static async Task<ResultDto<TimeSpan>> Converter(string value)
        {
            value = value.Trim();

            if (int.TryParse(value, out var hourse))
            {
                var result = new TimeSpan(hourse, 0, 0);

                if (result.TotalDays >= 1)
                {
                    return new ResultDto<TimeSpan>()
                    {
                        IsSuccess = false,
                        Message = "ساعت وارد شده نباید بزرگ تر از 23:59:59 باشد"
                    };
                }

                return new ResultDto<TimeSpan>()
                {
                    Data = result,
                    IsSuccess = true
                };
            }

            if (TimeSpan.TryParse(value, out var timeSpanResult))
            {

                if (timeSpanResult.TotalDays >= 1)
                {
                    return new ResultDto<TimeSpan>()
                    {
                        IsSuccess = false,
                        Message = "ساعت وارد شده نباید بزرگ تر از 23:59:59 باشد"
                    };
                }

                return new ResultDto<TimeSpan>()
                {
                    Data = timeSpanResult,
                    IsSuccess = true
                };
            }

            return new ResultDto<TimeSpan>()
            {
                IsSuccess = false,
                Message = "فرمت وارد شده صحیح نیست"
            };
        }
    }
}