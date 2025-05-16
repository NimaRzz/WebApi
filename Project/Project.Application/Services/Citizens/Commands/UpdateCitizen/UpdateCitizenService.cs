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

namespace Project.Application.Services.Citizens.Commands.UpdateCitizen
{
    public class UpdateCitizenService : IUpdateCitizenService
    {
        private readonly ICitizenRepository _repository;

        public UpdateCitizenService(ICitizenRepository repository) { 
        
            _repository = repository;
        }

        public async Task<ResultDto> Execute(RequestUpdateCitizenDto request)
        {

            var citizen = await _repository.Get<Citizen>(request.Id);


            if (!citizen.IsSuccess)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "تبعه ای با این شناسه وجود ندارد"
                };
            }

            citizen.Data.Name = request.Name;

            await _repository.Update<Citizen>(citizen.Data);
            await _repository.SaveAsync();

            return new ResultDto
            {
                IsSuccess = true,
                Message = "تبعه با موفقیت اپدیت شد"
            };
        }
    }
}
