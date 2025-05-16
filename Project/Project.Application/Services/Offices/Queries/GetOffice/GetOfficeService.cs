using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Application.Common.Provinces;
using Project.Application.Interfaces.Offices;
using Project.Domain.Common.Dto;
using Project.Domain.Entities.Offices;
using Project.Domain.Repository.Office;
using Project.Application.Services.Offices.Commands.DTOs;
using Project.Domain.Entities.Plans;


namespace Project.Application.Services.Offices.Queries.GetOffice
{
    public class GetOfficeService:IGetOfficeService
    {

        private readonly IOfficeRepository _repository;

        public GetOfficeService(IOfficeRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultDto<ResultGetOfficeDto>> Execute(string Id)
        {
            var office = await _repository.Get<Office>(Id);

            if (office.Data == null)
            {
                return new ResultDto<ResultGetOfficeDto>()
                {
                    IsSuccess = false,
                    Message = "دفتری با این شماره دفتر وجود ندارد"
                };
            }

            var officePlans = await _repository.GetOfficePlans(Id);
           
            List<string> plans = new();

            if (officePlans.IsSuccess)
            {
                foreach (var item in officePlans.Data) { 
                  
                        var plan = await _repository.Get<Plan>(item.PlanId);
                        if (plan.IsSuccess)
                        {
                            plans.Add(plan.Data.Name);
                        }
                    
                }
            }

            var workCalendars = await _repository.GetAllWorkCalendarsAsync(Id);
          
            List<OfficeWorkCalendarCommandsDto> calendars = new();

            foreach (var item in workCalendars)
            {
                var setItems = new OfficeWorkCalendarCommandsDto()
                {
                    Workday = item.Workday,
                    WorkEnd = item.WorkEnd.ToString(),
                    WorkStart = item.WorkStart.ToString()
                };
               
                calendars.Add(setItems);
            }

            var provinceId = office.Data.ProvinceId;

            string province = Enum.GetName(typeof(ProvincesEnum), provinceId);

            ResultGetOfficeDto result = new()
            {
                Id = Id,
                Address = office.Data.Address,
                Name = office.Data.Name,
                Province = province,
                Workdays = calendars,
                Plans = plans
            };

            return new ResultDto<ResultGetOfficeDto>()
            {
                Data = result,
                IsSuccess = true,
                Message = "دفتر با موفقیت دریافت شد"
            };
        }
    }
}
