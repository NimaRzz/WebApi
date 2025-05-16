using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Application.Common.Validations.Citizen;
using Project.Application.Interfaces.Citizens;
using Project.Domain.Common.Dto;
using Project.Domain.Entities.Citizens;
using Project.Domain.Repository.Citizen;

namespace Project.Application.Services.Citizens.Commands.AddCitizen
{
    public class AddCitizenService : IAddCitizenService
    {
        private readonly ICitizenRepository _repository;
        public AddCitizenService(ICitizenRepository repository) 
        {
        
            _repository = repository;
        
        }


        public async Task<ResultDto> Execute(RequestAddCitizenDto request)
        {

             Citizen citizen = new()
            {
                 Name = request.Name,
                 HouseholdCode = request.HouseholdCode,
                UniqueCode = request.UniqueCode,
                PassportCode = request.PassportCode,
                PersonalizedCode = request.PersonalizedCode,
            };

            var IsExists = await _repository.GetCitizen(citizen);

            if (!IsExists.IsSuccess)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = IsExists.Message
                };
            }

           var validate = await CitizenValidator.ValidateRequest(request, _repository);

            if (!validate.IsSuccess)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = validate.Message
                };
            }

            await _repository.Add<Citizen>(citizen);
            await _repository.SaveAsync();

            return new ResultDto
            {
                IsSuccess = true,
                Message = "تبعه با موفقیت افزوده شد"
            };
        }
    }
}
