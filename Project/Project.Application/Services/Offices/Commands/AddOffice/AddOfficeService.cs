using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Project.Application.Common.Converter;
using Project.Domain.Common.Dto;
using Project.Application.Common.Validations.Office;
using Project.Application.Interfaces.Offices;
using Project.Domain.Entities.Offices;
using Project.Domain.Repository.Office;
using Project.Application.Services.Offices.Commands.AddOffice;
using Project.Domain.Entities.Province;
using Project.Application.Common.Validations.Common;
using Project.Application.Common.GenerateId;
using Project.Application.Common.Provinces;

namespace Project.Application.Services.Offices.Commands.AddOffice
{
    public class AddOfficeService : IAddOfficeService
    {
        private readonly IOfficeRepository _repository;

        public AddOfficeService(IOfficeRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultDto> Execute(RequestAddOfficeDto request)
        {

            var idChecker = await BigIdChecker.IsBig<string>(request.Id);

            long id = 0;
            if (idChecker.IsSuccess)
            {
                id = Convert.ToInt64(request.Id);
            }
            else
            {
                return idChecker;
            }



           var Id = await CustomIdGenerator.GenerateId<long, long>(request.ProvinceId, id);

            var existsResult = await _repository.Get<Office>(Id);

            if (existsResult.IsSuccess)
            {

                return new ResultDto()
                {
                    IsSuccess = false,
                    Message = "دفتری با این شماره وجود دارد"
                };
            }

            var validationResult = await OfficeValidator.ValidateOfficeRequest(request);

            if (!validationResult.IsSuccess)
            {
                return validationResult;
            }

            // بررسی استان
            if (request.ProvinceId > 31 || request.ProvinceId < 1)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "این استان وجود ندارد. از اعداد 1 تا 31 انتخاب کنید"
                };
            }

            List<WorkCalendar> workCalendar = new();

            foreach (var item in request.Workdays)
            {
                var workStart = await ConvertToTimeSpan.Converter(item.WorkStart);
                var workEnd = await ConvertToTimeSpan.Converter(item.WorkEnd);
                if (!workStart.IsSuccess)
                {
                    return workStart;
                }
                if (!workEnd.IsSuccess)
                {
                    return workStart;
                }

             WorkCalendar wc = new()
                {
                    Workday = item.Workday,
                    WorkStart = workStart.Data,
                    WorkEnd = workEnd.Data,
                };

                workCalendar.Add(wc);
            }
            



            Office office = new()
            {
                Id = Id,
                Name = request.Name,
                ProvinceId = request.ProvinceId,
                Address = request.Address,
                WorkCalendars = workCalendar

            };



            await _repository.Add<Office>(office);
            await _repository.SaveAsync();

            
            return new ResultDto()
            {
                IsSuccess = true,
                Message = "دفتر با موفقیت افزوده شد"
            };
        }
    }
}
