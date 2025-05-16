using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Domain.Common.Dto;

namespace Project.Application.Common.Validations.Common
{
    public class BigIdChecker
    {
        public static async Task<ResultDto> IsBig<T>(T value)
        {

            if (value is string Id)
            { 
            if (long.TryParse(Id, out long id))
            {
               
                if (id < 100)
                {
                    return new ResultDto()
                    {
                        IsSuccess = true
                    };
                }
                return new ResultDto()
                {
                    IsSuccess = false,
                    Message = "شناسه باید کوچک تر از 100 باشد"
                };

            }
            return new ResultDto()
            {
                IsSuccess = false,
                Message = "شناسه طرح باید عدد باشد"
            };
            }
            return new ResultDto()
            {
                IsSuccess = false,
                Message = "شناسه طرح باید از نوع استرینگ باشد"
            };
        } 
    }
}
