using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Project.Application.Services.Citizens.Commands.DTOs;
using Project.Domain.Common.Dto;
using Project.Domain.Repository.Citizen;
using CitizenModel =  Project.Domain.Entities.Citizens.Citizen;

namespace Project.Application.Common.Validations.Citizen
{
    public static class CitizenValidator
    {
        public static async Task<ResultDto> ValidateRequest(CitizenCommandsDto request, ICitizenRepository _repository)
        {

            if(string.IsNullOrEmpty(request.Name) || request.HouseholdCode == 0 || request.UniqueCode == 0 || string.IsNullOrEmpty(request.PassportCode.ToString()) || request.PersonalizedCode == 0 )
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "لطفا تمامی اطلاعات خواسته شده را تکمیل کنید"
                };
            }
           
            string householdCodePattern = @"^\d{10}$";

            string uniqueCodePattern = @"^\d{9,}$";

            string passportCodePattern = @"^(?=.*[A-Za-z])(?=.*\d)[a-zA-Z\d]{6,9}$";

            string personalizedCodePattern = @"^\d{12}$";

            if (!Regex.IsMatch(request.HouseholdCode.ToString(), householdCodePattern))
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "کد خانوار باید 10 رقم باشد"
                };
            }

            if (!Regex.IsMatch(request.UniqueCode.ToString(), uniqueCodePattern))
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "کد یکتا باید بیشتر از 9 رقم باشد"
                };
            }

            if (!Regex.IsMatch(request.PassportCode.ToString(), passportCodePattern))
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "کد پاسپورت باید 6 تا 9 عدد و حرف انگلیسی باشد"
                };
            }

            if (!Regex.IsMatch(request.PersonalizedCode.ToString(), personalizedCodePattern))
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "کد اختصاصی باید 12 رقم باشد"
                };
            }

            return new ResultDto
            {
                IsSuccess = true
            };
        }
    }
}
