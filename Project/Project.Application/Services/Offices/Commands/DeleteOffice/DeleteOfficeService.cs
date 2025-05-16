using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Domain.Common.Dto;
using Project.Application.Common.Validations.Office;
using Project.Application.Interfaces.Offices;
using Project.Domain.Entities.Offices;
using Project.Domain.Repository.Office;

namespace Project.Application.Services.Offices.Commands.DeleteOffice
{
    public class DeleteOfficeService:IDeleteOfficeService
    {

        private readonly IOfficeRepository _repository;

        public DeleteOfficeService(IOfficeRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultDto> Execute(string Id)
        {

            var entity = await _repository.Get<Office>(Id);

            if (entity.IsSuccess == false)
            {

                return new ResultDto()
                {
                    IsSuccess = false,
                    Message = "دفتری با این شماره وجود ندارد"
                };
            }


            await _repository.Delete<Office>(entity.Data);
                await _repository.SaveAsync();

            return new ResultDto()
                {
                    IsSuccess = true,
                    Message = "دفتر با موفقیت حذف شد"
                };
                
        }
    }
}
