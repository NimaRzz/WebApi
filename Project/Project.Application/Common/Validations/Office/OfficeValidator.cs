using Project.Domain.Common.Dto;
using Project.Application.Services.Offices.Commands.AddOffice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Project.Application.Services.Offices.Commands.UpdateOffice;
using Project.Domain.Repository.Office;
using Project.Application.Common.Converter;
using Project.Domain.Entities.Offices;
using Project.Application.Services.Offices.Commands.DTOs;

namespace Project.Application.Common.Validations.Office
{
    public class OfficeValidator
    {

        public static async Task<ResultDto> ValidateOfficeRequest(OfficeCommandsDto request)
        {
            ResultDto result = new();

          
           result = await ValidateRequest(request.Id, request.Name, request.Address, request.Workdays);
            

            return result;
        }

        private static async Task<ResultDto> ValidateRequest(string id, string name, string address, List<OfficeWorkCalendarCommandsDto> workDays)
        {
            // بررسی اینکه شماره دفتر وارد شده باشد
            if (string.IsNullOrEmpty(id))
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "شماره دفتر را وارد کنید"
                };
            }

            // بررسی نام دفتر
            if (string.IsNullOrEmpty(name))
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "نام دفتر را وارد کنید"
                };
            }

            string pattern = @"^[\u0600-\u06FF0-9 ]+$";
            if (!Regex.IsMatch(name, pattern))
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "فقط حروف فارسی و اعداد مجاز هستند."
                };
            }


            // بررسی آدرس دفتر
            if (string.IsNullOrEmpty(address))
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "ادرس را وارد کنید"
                };
            }

            foreach (var item in workDays)
            {
                var workStartResult = await ConvertToTimeSpan.Converter(item.WorkStart);
                var workEndResult = await ConvertToTimeSpan.Converter(item.WorkEnd);

                if (!workStartResult.IsSuccess)
                {
                    return workStartResult;
                }

                if (!workEndResult.IsSuccess)
                {
                    return workEndResult;
                }

                if (workStartResult.Data >= workEndResult.Data)
                {
                    return new ResultDto
                    {
                        IsSuccess = false,
                        Message = "ساعت پایان کاری باید بعد از ساعت شروع کاری باشد"
                    };
                }

                List<DaysOfTheWeek> days = Enum.GetValues(typeof(DaysOfTheWeek)).Cast<DaysOfTheWeek>().ToList();

                if (!days.Contains(item.Workday))
                {
                    return new ResultDto
                    {
                        IsSuccess = false,
                        Message = "روز هایه وارد شده باید از روز هایه هفته باشد(از عدد 1 تا 7)"
                    };
                }
            }

            return new ResultDto()
            {
                IsSuccess = true
            }; // اگر هیچ خطایی نبود، null برگشت می‌دهیم.
        }

       
    }

}
