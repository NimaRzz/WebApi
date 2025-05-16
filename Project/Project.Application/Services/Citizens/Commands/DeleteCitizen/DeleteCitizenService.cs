using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Application.Interfaces.Citizens;
using Project.Domain.Common.Dto;
using Project.Domain.Entities.Citizens;
using Project.Domain.Repository.Citizen;

namespace Project.Application.Services.Citizens.Commands.DeleteCitizen
{
    public class DeleteCitizenService: IDeleteCitizenService
    {
        private readonly ICitizenRepository _repository;
        public DeleteCitizenService(ICitizenRepository repository) 
        {
          _repository = repository;
        }

        public async Task<ResultDto> Execute(long Id)
        {


            var citizen = await _repository.Get<Citizen>(Id);


            if (!citizen.IsSuccess)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "تبعه ای با این شناسه وجود ندارد"
                };
            }

           await _repository.Delete<Citizen>(citizen.Data);
           await _repository.SaveAsync();

            return new ResultDto()
                {
                    IsSuccess = true,
                    Message = "تبعه با موفقیت حذف شد"
                };

        }
    }
}
