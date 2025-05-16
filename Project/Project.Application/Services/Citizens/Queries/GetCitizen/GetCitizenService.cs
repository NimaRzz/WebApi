using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Application.Interfaces.Citizens;
using Project.Domain.Common.Dto;
using Project.Domain.Entities.Citizens;
using Project.Domain.Repository.Citizen;

namespace Project.Application.Services.Citizens.Queries.GetCitizen
{
    public class GetCitizenService: IGetCitizenService
    {
        private readonly ICitizenRepository _repository;

        public GetCitizenService(ICitizenRepository repository)
        {
            _repository = repository;
        }
         
        public async Task<ResultDto<ResultGetCitizenDto>> Execute(long Id)
        {
            var citizen = await _repository.Get<Citizen>(Id);

            if (citizen.Data == null)
            {
                return new ResultDto<ResultGetCitizenDto>()
                {
                    IsSuccess = false,
                    Message = "تبعه ای با این شناسه وجود ندارد"
                };
            }

            ResultGetCitizenDto result = new()
            {
                Id = Id,
                Name = citizen.Data.Name,
                HouseholdCode = citizen.Data.HouseholdCode,
                UniqueCode = citizen.Data.UniqueCode,
                PassportCode = citizen.Data.PassportCode,
                PersonalizedCode = citizen.Data.PersonalizedCode
            };

            return new ResultDto<ResultGetCitizenDto>
            {
                Data = result,
                IsSuccess = true,
                Message = "تبعه با موفقیت دریافت شد"
            };
        }
    }
}
