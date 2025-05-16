using Project.Domain.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Application.Services.Plans.Commands.AddPlan;
using Project.Application.Common.Validations.Common;
using System.Text.RegularExpressions;
using Project.Application.Services.Plans.Commands.UpdatePlan;

namespace Project.Application.Common.Validations.Plan
{
    public class PlanValidator
    {

        public static async Task<ResultDto> ValidatePlanRequest(object request)
        {
            ResultDto result = new();

            if (request is RequestUpdatePlanDto updateRequest)
            {
                result = await ValidateRequest(updateRequest.Id, updateRequest.Name, updateRequest.Capacity, updateRequest.StartPlan, updateRequest.EndPlan);
            }
            else if (request is RequestAddPlanDto addRequest)
            {
                result = await ValidateRequest(addRequest.Id, addRequest.Name, addRequest.Capacity, addRequest.StartPlan, addRequest.EndPlan);
            }

            return result;
        }

        public static async Task<ResultDto> ValidateRequest(string id, string name, int capacity, DateTime startPlan, DateTime endPlan)
        {

            if (string.IsNullOrEmpty(id))
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "شناسه طرح را وارد کنید"
                };
            }

            long.TryParse(id, out long idResult);

            if (idResult < 1000 || idResult > 9999)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "شناسه طرح باید بین 1000 و 9999 باشد"
                };
            }

            string pattern = @"^[\u0600-\u06FF0-9]+$";
            if (!Regex.IsMatch(name, pattern))
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "فقط حروف فارسی و اعداد مجاز هستند."
                };
            }

            if (capacity <= 0)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "ظرفیت طرح باید بیشتر از 0 باشد"
                };
            }

            if (startPlan >= endPlan)
            {
                return new ResultDto()
                {
                    IsSuccess = false,
                    Message = "تاریخ پایان طرح باید بعد از تاریخ شروع طرح باشد"
                };
            }

            return new ResultDto()
            {
                IsSuccess = true
            }; // اگر هیچ خطایی نبود، null برگشت می‌دهیم.
        }
    }
}
